using Microsoft.Win32;
using System;

namespace Stub.Modules.InternalFuncs
{
    internal class MutexManager
    {
        public static void Initialize()
        {
            string keyName = @"SOFTWARE\" + config.MutexValue;

            // Проверяем, существует ли ключ в реестре
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(keyName);
            if (registryKey != null)
            {
                // Если ключ уже существует, завершаем работу программы
                registryKey.Close();
                Environment.FailFast("");
            }
            else
            {
                // Если ключ не существует, то создаем его
                Registry.CurrentUser.CreateSubKey(keyName);
            }
        }
    }
}
