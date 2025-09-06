using QM_UnityExplorer.Utility;
using QM_UnityExplorer.Utility.Mcm;
using ModConfigMenu;
using ModConfigMenu.Objects;
using QM_UnityExplorer;
using QM_UnityExplorer.Utility.Mcm;
using System.Collections.Generic;
using UnityEngine;
using Logger = QM_UnityExplorer.Utility.Logger;

namespace QM_UnityExplorer
{
    internal class McmConfiguration : McmConfigurationBase
    {

        public McmConfiguration(ModConfig config, Logger logger) : base (config, logger) { }

        public override void Configure()
        {
            ModConfigMenuAPI.RegisterModConfig("Unity Explorer", new List<ConfigValue>()
            {
                CreateRestartMessage(),
                CreateConfigProperty(nameof(ModConfig.Enabled),
                    @"If true, will load the Unity Explorer.  This allow disabling the utility without uninstalling the mod.")
            }, OnSave);
        }
    }
}
