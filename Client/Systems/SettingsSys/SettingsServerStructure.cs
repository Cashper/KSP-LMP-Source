﻿using CommNet;
using LunaCommon.Enums;

namespace LunaClient.Systems.SettingsSys
{
    public class SettingsServerStructure
    {
        public WarpMode WarpMode { get; set; } = WarpMode.Subspace;
        public GameParameters ServerParameters { get; set; }
        public GameParameters.AdvancedParams ServerAdvancedParameters { get; set; } = new GameParameters.AdvancedParams();
        public CommNetParams ServerCommNetParameters { get; set; } = new CommNetParams();
        public GameMode GameMode { get; set; }
        public TerrainQuality TerrainQuality { get; set; }
        public bool AllowCheats { get; set; }
        public bool AllowAdmin { get; set; }
        public bool AllowSackKerbals { get; set; }
        public int MaxNumberOfAsteroids { get; set; }
        public string ConsoleIdentifier { get; set; } = "";
        public GameDifficulty GameDifficulty { get; set; }
        public float SafetyBubbleDistance { get; set; } = 100f;
        public int VesselUpdatesMsInterval { get; set; }
        public int SecondaryVesselUpdatesMsInterval { get; set; }
        public bool ForceInterpolationOffset { get; set; }
        public bool ForceInterpolation { get; set; }
        public bool ForceExtrapolation { get; set; }
        public string WarpMaster { get; set; }
        public int VesselPartsSyncMsInterval { get; set; }
        public bool ShowVesselsInThePast { get; set; }
        public int MinScreenshotIntervalMs { get; set; }
        public int MaxScreenshotWidth { get; set; }
        public int MaxScreenshotHeight { get; set; }
        public int MinCraftLibraryRequestIntervalMs { get; set; }
    }
}
