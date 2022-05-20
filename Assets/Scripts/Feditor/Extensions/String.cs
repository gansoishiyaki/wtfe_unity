using System;
static class StringExtensions
{
    /// <summary>
    /// stringからEnumに変換する。
    /// 変換できなかった場合はデフォルト値を返却する
    /// </summary>
    /// <typeparam name="T">変換するEnum</typeparam>
    /// <param name="s">string</param>
    /// <param name="def">デフォルトの値</param>
    /// <returns></returns>
    public static T ToEnum<T>(this string s, T def) where T : struct
    {
        if (s == string.Empty || !Enum.IsDefined(typeof(T), s))
            return def;
        return Enum.Parse<T>(s);
    }
}