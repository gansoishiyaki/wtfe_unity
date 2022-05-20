using System;
using UnityEngine;

/// <summary>
/// Game全体の管理用非コントローラー
/// シングルトン
/// </summary>
public class GameController
{
    // private
    private static GameController _gameController; // インスタンス

    // public
    public SystemData systemData;

    /// <summary>
    /// コンストラクタ
    /// 外部から呼び出し不可
    /// </summary>
    [Obsolete]
    private GameController()
    {
        // 初期化処理
        // Screen.SetResolution(width: Const.GameMain.Witdh, height: Const.GameMain.Height, false, Const.GameMain.RefreshRate);

        systemData = new SystemData("Data");
    }

    /// <summary>
    /// ゲーム起動時に自動で呼ばれる
    /// </summary>
    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        // 初期化処理
        _ = getInstance;
    }

    /// <summary>
    /// インスタンス取得
    /// </summary>
    public static GameController getInstance
    {
        get
        {
            if (_gameController == null)
#pragma warning disable CS0612 // Type or member is obsolete
                _gameController = new GameController();
#pragma warning restore CS0612 // Type or member is obsolete

            return _gameController;
        }
    }
}
