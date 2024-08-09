using EFT;
using HarmonyLib;
using SPT.Reflection.Patching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SPTClientModExamples.ExamplePatches
{
    internal class SimplePatch : ModulePatch // all patches must inherit ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            // one way methods can be patched is by targeting both their class name and the name of the method itself
            // the example in this patch is the Jump() method in the Player class
            return AccessTools.Method(typeof(Player), nameof(Player.Jump));
        }

        public static int maxJumps = 3;
        public static int completedJumps = 0;

        [PatchPrefix]
        static bool Prefix()
        {
            // code in Prefix() method will run BEFORE original code is executed.
            // if 'true' is returned, the original code will still run.
            // if 'false' is returned, the original code will be skipped.

            if (completedJumps < maxJumps)
            {
                completedJumps++;
                int remainingJumps = maxJumps - completedJumps;

                // we are using that LogSource variable we set up in the Plugin.cs file.
                Plugin.LogSource.LogWarning($"You jumped! You have {remainingJumps} left!");

                return true; // return true to run the original code and jump!
            }
            else
            {
                Plugin.LogSource.LogError("You have no jumps left!");

                return false; // we are out of jumps, so we return false, preventing the original jump code from running.
            }
        }

        [PatchPostfix]
        static void Postfix()
        {
            // code in Postfix() method runs AFTER the original code is executed
        }

        // uncomment the 'new SimplePatch().Enable();' line in your Plugin.cs script to enable this patch.
    }
}
