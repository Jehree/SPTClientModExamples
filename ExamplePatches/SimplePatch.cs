using EFT;
using HarmonyLib;
using SPT.Reflection.Patching;
using System.Reflection;

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

        public static int MaxJumps = 3;
        public static int CompletedJumps = 0;

        [PatchPrefix]
        static bool Prefix()
        {
            // code in Prefix() method will run BEFORE original code is executed.
            // if 'true' is returned, the original code will still run.
            // if 'false' is returned, the original code will be skipped.

            if (CompletedJumps < MaxJumps)
            {
                CompletedJumps++;
                int remainingJumps = MaxJumps - CompletedJumps;

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
