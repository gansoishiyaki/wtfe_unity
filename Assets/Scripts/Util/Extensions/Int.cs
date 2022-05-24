using System;
static class IntExtensions
{
    /// <summary>
    /// 1 ~ 自身の数のランダムな数値を返却する
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int RandomInt(this int value)
    {
        var random = new Random();
        return random.Next(0, value) + 1;
    }
}