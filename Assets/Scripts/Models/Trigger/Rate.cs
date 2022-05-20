namespace Model.Trigger
{
    /// <summary>
    /// トリガーターゲット
    /// </summary>
    public enum Rate
    {
        all,     // 必ず
        hit,     // 攻撃命中時
        damage   // ダメージ付与時
    }
}