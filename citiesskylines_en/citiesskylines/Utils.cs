using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using ColossalFramework.IO;
using ColossalFramework.Globalization;

namespace CitiesSkylines
{
    class Utils
    {
        public static T GetPrivateField<T>(object instance, string fieldname)
        {
            BindingFlags flag = BindingFlags.Instance | BindingFlags.NonPublic;
            Type type = instance.GetType();
            FieldInfo field = type.GetField(fieldname, flag);
            return (T)field.GetValue(instance);
        }

        public static void SetPrivateField<T>(object instance, string fieldname, object obj)
        {
            BindingFlags flag = BindingFlags.Instance | BindingFlags.NonPublic;
            Type type = instance.GetType();
            FieldInfo field = type.GetField(fieldname, flag);
            field.SetValue(instance, obj);
        }

        public static void ExportPOFile(string path, Dictionary<Locale.Key, string> m_LocalizedStrings)
        {
            using (StreamWriter file = new StreamWriter(path))
            {
                foreach (KeyValuePair<Locale.Key, string> current in m_LocalizedStrings)
                {
                    file.WriteLine("#. \"{0}\"", current.Key);
                    file.WriteLine("msgid \"{0}\"", current.Value.Replace("\r", @"\r").Replace("\n", @"\n"));
                    file.WriteLine("msgstr \"{0}\"", "");
                }
            }
        }

        const uint FORMAT_VERSION = 2u;
        public static void ExportFile(string path, Locale m_Locale)
        {
            using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                DataSerializer.Serialize(stream, DataSerializer.Mode.File, FORMAT_VERSION, m_Locale);
            }
        }
    }
}
