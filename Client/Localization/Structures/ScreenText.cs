﻿namespace LunaClient.Localization.Structures
{
    public class ScreenText
    {
        public string CraftUploaded { get; set; } = "Craft uploaded!";
        public string CraftSaved { get; set; } = "Craft saved!";
        public string ModFileGenerated { get; set; } = "LMPModControl.xml file generated in your KSP folder";
        public string Disconected { get; set; } = "You have been disconnected!";
        public string Spectating { get; set; } = "This vessel is being controlled by";
        public string SafetyBubble { get; set; } = "Remember!! While you're inside the safety bubble you won't be seen by other players!!";
        public string CannotRecover { get; set; } = "Cannot recover vessel, the vessel is not yours.";
        public string CannotTerminate { get; set; } = "Cannot terminate vessel, the vessel is not yours.";
        public string SpectatingRemoved { get; set; } = "The vessel you were spectating was removed";
        public string WarpDisabled { get; set; } = "Cannot warp, warping is disabled on this server";
        public string NotWarpMaster { get; set; } = "Cannot warp, you are not the warp master!";
        public string WaitingSubspace { get; set; } = "Cannot warp, waiting subspace id from the server";
        public string ScreenshotInterval { get; set; } = "Interval between screenshots is $1 seconds. Cannot upload the screenshot at this moment";
        public string ScreenshotTaken { get; set; } = "Screenshot uploaded!";
        public string ImageSaved { get; set; } = "Image saved to GameData/LunaMultiplayer/Screenshots";
    }
}
