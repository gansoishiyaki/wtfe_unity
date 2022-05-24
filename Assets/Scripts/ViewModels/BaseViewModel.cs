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
}