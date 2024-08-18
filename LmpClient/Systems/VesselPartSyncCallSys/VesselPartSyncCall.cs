using HarmonyLib;
using LmpClient.Events;
using LmpClient.Extensions;
using LmpClient.VesselUtilities;
using System;
using System.Reflection;

namespace LmpClient.Systems.VesselPartSyncCallSys
{
    /// <summary>
    /// Class that maps a message class to a system class. This way we avoid the message caching issues
    /// </summary>
    public class VesselPartSyncCall
    {
        #region Fields and Properties

        public double GameTime;
        public Guid VesselId;

        public uint PartFlightId;
        public string ModuleName;
        public string MethodName;

        #endregion

        public void ProcessPartMethodCallSync()
        {
            var vessel = FlightGlobals.FindVessel(VesselId);
            if (vessel == null || !vessel.loaded) return;

            if (!VesselCommon.DoVesselChecks(VesselId))
                return;

            var part = vessel.protoVessel.GetProtoPart(PartFlightId);
            if (part != null)
            {
                var module = part.FindProtoPartModuleInProtoPart(ModuleName);
                if (module != null)
                {
                    if (module.moduleRef != null)
                    {
                        MethodInfo[] methods = module.moduleRef.GetType().GetMethods(AccessTools.all);
                        // check if the method has the [KSPEvent] attribute and has the same name
                        MethodInfo usingMethod = null;
                        foreach (MethodInfo method in methods) {
                            if(method.Name.Equals(MethodName) && method.GetCustomAttributes(typeof(KSPEvent), false)?.Length > 0){
                                usingMethod = method;
                                break;
                            }
                        }
                        if(usingMethod == null){
                            LunaLog.LogWarning("Could not find method to call for KSPEvent!");
                        }else{
                            LunaLog.Log($"Using method {usingMethod.Name}");
                            usingMethod.Invoke(module.moduleRef, null);
                        }
                        //module.moduleRef.GetType().GetMethod(MethodName, AccessTools.all)?.Invoke(module.moduleRef, null); // this is the original code
                        PartModuleEvent.onPartModuleMethodProcessed.Fire(module, MethodName);
                    }
                }
            }
        }
    }
}
