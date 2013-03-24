using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ThinkingHome.NooLite
{
    public static class PC118Commands
    {
        public static List<string> GetCommandsList()
        {
            List<string> result = new List<string>();
            foreach (Pc118Command cmd in Enum.GetValues(typeof(Pc118Command)))
            {
                string description = EnumHelper<Pc118Command>.GetEnumDescription(cmd.ToString());
                result.Add(string.Format("{0} - {1}", cmd.ToString(), description));
            }
            return result;            
        }        

        public static class EnumHelper<T>
        {
            public static string GetEnumDescription(string value)
            {
                Type type = typeof(T);
                var name = Enum.GetNames(type).Where(f => f.Equals(value, StringComparison.CurrentCultureIgnoreCase)).Select(d => d).FirstOrDefault();

                if (name == null)
                {
                    return string.Empty;
                }
                var field = type.GetField(name);
                var customAttribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
                return customAttribute.Length > 0 ? ((DescriptionAttribute)customAttribute[0]).Description : name;
            }
        }
    }

    public enum Pc118Command : byte
    {
        [Description("Turn on the light")]
        On = 0x02,
        [Description("Turn off the light")]
        Off = 0x00,
        Switch = 0x04,
        SetLevel = 0x06,
        Bind = 0x0f,
        UnBind = 0x09,
    }
}