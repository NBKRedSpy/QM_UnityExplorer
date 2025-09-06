using HarmonyLib;
using MGSC;
using QM_UnityExplorer.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityExplorer;

namespace QM_UnityExplorer
{
    public static class Plugin
    {

        public static ConfigDirectories ConfigDirectories = new ConfigDirectories();

        public static ModConfig Config { get; private set; }

        public static Utility.Logger Logger = new();

        private static McmConfiguration McmConfiguration;


        [Hook(ModHookType.AfterConfigsLoaded)]
        public static void AfterConfig(IModContext context)
        {
            Directory.CreateDirectory(ConfigDirectories.ModPersistenceFolder);

            Config = ModConfig.LoadConfig(ConfigDirectories.ConfigPath, Logger);

            McmConfiguration = new McmConfiguration(Config, Logger);
            McmConfiguration.TryConfigure();

            if(Config.Enabled)
            {
                ExplorerStandalone.CreateInstance();
            }
            
        }
     
    }
}
