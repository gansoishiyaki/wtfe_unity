using System;
using UnityEngine;

/// <summary>
/// Game全体の管理用非コントローラー
/// シングルトン
/// </summary>
public class Main
{
    public Registory Registory;

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
        var json = new Resource.JSONHandler("Data");
        var store = new DataStore.JSON.Handler("");

        // レジストリ管理
        Registory = new Registory(json, store);

        // ダミーデータ作成
        Dummy.CreateDummyData(Registory);
    }

    /// <summary>
    /// ゲーム起動時に自動で呼ばれる
    /// </summary>
    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        // 初期化処理
        _ = Get;
    }

    /// <summary>
    /// インスタンス取得
    /// </summary>
    public static Main Get
    {
        get
        {
            if (main == null)
                main = new Main();

            return main;
        }
    }
}
