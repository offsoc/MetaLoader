// Coded by k3rnel-dev(@k666_dev) - Telegram | github.com/k3rnel-dev
using Stub.Modules.InternalFuncs;
using Stub.Modules.Protects;

namespace Stub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AllChecker.Protect();
            InternalMain.Execute();
        }
    }
}
