using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace SharedLib
{
    public  class clsRegistry
    {

        public static bool SaveToRegistry(string KeyPath, string ValueName, string ValueData,
           RegistryValueKind Type )
        {
            try
            {
                // Write the value to the Registry
                Registry.SetValue(KeyPath, ValueName, ValueData, Type);


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static T ReadFromRegistry<T>(string KeyPath, string ValueName)
        {
            try
            {
                // Read the value from the Registry
                object value = Registry.GetValue(KeyPath, ValueName, null);

                return (T) value;

            }
            catch (Exception ex)
            {
                return default;
            }
        }

        /// <summary>
        ///  Deletes a value from the Windows Registry. 
        /// </summary>
        /// <param name="KeyPath">The path of registry key without the registry hive name </param>
        /// <param name="ValueName">The name of the value to delete.</param>
        /// <param name="RegHive">The registry hive name (current_user or localmachine)</param>

        /// <returns>True if the value was deleted successfully; otherwise, false.</returns>
        public static bool DeleteValueFromRegistry(string KeyPath,string ValueName, RegistryHive RegHive)
        {
            try
            {
                // Open the registry key in read/write mode with explicit registry view
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegHive, RegistryView.Default))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(KeyPath, true))
                    {
                        if (key != null)
                        {
                            // Delete the specified value
                            key.DeleteValue(ValueName);

                            return true;
                        }
                        return false;
                    }
                }
            }
 
            catch (Exception ex)
            {
                //Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }

        }
    }
}
