using System;
using UnityEngine;

/// <summary>
/// Game全体の管理用非コントローラー
/// シングルトン
/// </summary>
public class Main
{
    // private
    private static Main main; // インスタンス

    /// <summary>
    /// コンストラクタ
    /// 外部から呼び出し不可
    /// </summary>
    private Main()
    {
        // 初期化処理
        // Screen.SetResolution(width: Const.GameMain.Witdh, height: Const.GameMain.Height, false, Const.GameMain.RefreshRate);

        // JSON読み込み初期化
        //IRepository.IResourceRepository json = new Resource.JSONHandler("Data");
    }

    /// <summary>
    /// ゲーム起動時に自動で呼ばれる
    /// </summary>
    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        // 初期化処理
        _ = Default;
    }

    /// <summary>
    /// インスタンス取得
    /// </summary>
    public static Main Default
    {
        get
        {
            if (main == null)
                main = new Main();

            return main;
        }
    }
}
