using QM_UnityExplorer.Utility;
using QM_UnityExplorer.Utility.Mcm;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;
using UnityEngine;


namespace QM_UnityExplorer;
public class ModConfig : PersistentConfig<ModConfig>, IMcmConfigTarget
{

    /// <summary>
    /// If false, will not load the Unity Explorer. 
    /// </summary>
    public bool Enabled { get; set; } = true;    

    public ModConfig() 
    {
    }


    public ModConfig(string configPath, Utility.Logger logger) : base(configPath, logger)
    {
    }

}
