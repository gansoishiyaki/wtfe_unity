using System;
static class StringExtensions
{
    public static T ToEnum<T>(this string s, T def) where T : struct
    {
        if (!Enum.IsDefined(typeof(T), s))
            return def;
        return Enum.Parse<T>(s);
    }
}