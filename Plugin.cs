using BepInEx;
using BepInEx.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPTClientModExamples.ExamplePatches;

namespace SPTClientModExamples
{
    // first string below is your plugin's GUID, it MUST be unique to any other mod. Read more about it in BepInEx docs. Be sure to update it if you copy this project.
    [BepInPlugin("SPTClientModExamples.UniqueGUID", "SPTClientModExamples", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        public static ManualLogSource LogSource;

        // BaseUnityPlugin inherits MonoBehaviour, so you can use base unity functions like Awake() and Update()
        private void Awake()
        {
            // save the Logger to variable so we can use it elsewhere in the project
            LogSource = Logger;
            LogSource.LogInfo("plugin loaded!");

            // uncomment line(s) below to enable desired example patch, then press F6 to build the project:
            //new SimplePatch().Enable();
        }
    }
}
