using BepInEx;
using BepInEx.Logging;
using Jehree.TestingThings.Patches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourModName
{
    //first string below is your plugin's GUID, it MUST be unique to any other mod. Read more about it in BepInEx docs. Be sure to update it if you copy this code.
    [BepInPlugin("YourUsername.YourModName", "YourModName", "0.0.1")]  
    public class Plugin : BaseUnityPlugin
    {
        public static ManualLogSource LogSource;

        //BaseUnityPlugin inherits MonoBehaviour, so you can use base unity functions like Awake() and Update()
        private void Awake() //Awake() will run once when your plugin loads
        {
            //we save the Logger to our LogSource variable so we can use it anywhere, such as in our patches via Plugin.LogSource.LogInfo(), etc.
            LogSource = Logger;
            LogSource.LogInfo("plugin loaded!");

            //uncomment the line below and replace "PatchClassName" with the class name you gave your patch. Patches must be enabled like this to work.
            //new PatchClassName().Enable();
        }
    }
}
