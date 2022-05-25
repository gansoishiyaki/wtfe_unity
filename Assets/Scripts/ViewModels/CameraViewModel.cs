using UnityEngine;
using System.Collections;

/// <summary>
/// カメラ
/// </summary>
public class CameraViewModel
{
    /// <summary>
    /// クリック開始
    /// </summary>
    public void Down()
    {
        Debug.Log(Input.mousePosition);
    }

    public void Up()
    {

    }
}