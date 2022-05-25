using UnityEngine;

/// <summary>
/// デリゲートなど
/// </summary>
public class BaseViewModel
{
    // 生成
    public delegate GameObject CreateChild(GameObject obj, GameObject parent = null);
    public CreateChild createChild;

    // 移動
    public delegate void SetPositon(Vector2 vector2);
    public SetPositon setPositon;

    /// <summary>
    /// タップ開始
    /// </summary>
    public void tapStart()
    {
    }

    /// <summary>
    /// タップ終了
    /// </summary>
    public void tapEnd()
    {
    }

    /// <summary>
    /// ドラッグ中
    /// </summary>
    public void drag()
    {

    }

    /// <summary>
    /// 短くタップされた
    /// </summary>
    public void SingleTap() { }

    /// <summary>
    /// 長く押された
    /// </summary>
    public void LongTap() { }
}