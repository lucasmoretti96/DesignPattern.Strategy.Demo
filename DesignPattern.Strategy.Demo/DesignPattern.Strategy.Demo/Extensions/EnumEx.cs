using System;

namespace DesignPattern.Strategy.Demo.Extensions
{
    public static class EnumEx
    {
        public static T? TryParseToEnum<T>(this int value) where T : struct
        {
            if (Enum.IsDefined(typeof(T), value))
                return (T)Enum.Parse(typeof(T), value.ToString());

            return null;
        }
    }
}
