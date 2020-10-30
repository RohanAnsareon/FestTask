using System;
using System.Collections.Generic;
using System.Text;

namespace FestTask.Application.Enums
{
    public static class EnumExtensions
    {
        public static string ToStringName<TEnum>(this TEnum key)
        {
            return Enum.GetName(typeof(TEnum), key);
        }
    }
}
