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
    [BepInPlugin("YourUsername.YourModName", "YourModName", "0.0.1")] //first string MUST be unique to any other mod. Read more about it in BepInEx docs. 
    public class Plugin : BaseUnityPlugin
    {
        public static ManualLogSource LogSource;

        private void Awake()
        {
            //we save the Logger to our LogSource variable so we can use it anywhere, such as in our patches via Plugin.LogSource.LogInfo(), etc.
            LogSource = Logger; 

            //uncomment the line below and replace "PatchClassName" with the class name you gave your patch. Patches must be enabled like this to do anything.
            //new PatchClassName().Enable();
        }
    }
}
