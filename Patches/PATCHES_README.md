The very basics of patches:

Patches allow you to hook on to a method in the source code and run your own code either before or after the original code runs. This allows you to do unique things at that time, change the output of a method, stop the method from running all together, etc.

I suggest reading the Harmony 2 docs below on patching, but bear in mind that some of the syntax we use for SPT mods is quite different from the standard Harmony way of doing it. The Harmony syntax also can work if you use the 0Harmony assembly, but I recommend using the Aki.Refletion.Patching method shown in the examples in this repo.

That said, the actual explanations given on the Harmony 2 docs are very good and I highly recommend you read them. Also take a look at injections, specifically the __result and __instance injections are very useful.

https://harmony.pardeike.net/articles/patching.html
