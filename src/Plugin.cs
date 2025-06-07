using HarmonyLib;
using MGSC;
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

        [Hook(ModHookType.AfterConfigsLoaded)]
        public static void AfterConfig(IModContext context)
        {
            ExplorerStandalone.CreateInstance();
        }
     
    }
}
