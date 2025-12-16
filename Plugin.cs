using BepInEx;
using BepInEx.Logging;

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
            // save the Logger to public static field so we can use it elsewhere in the project
            LogSource = Logger;
            LogSource.LogInfo("plugin loaded!");

            // uncomment line(s) below to enable desired example patch, then press F6 to build the project
            // if this solution is properly placed in a YourSPTInstall/Development folder, the compiled plugin will automatically be copied into YourSPTInstall/BepInEx/plugins
            // new SimplePatch().Enable();
        }
    }
}
