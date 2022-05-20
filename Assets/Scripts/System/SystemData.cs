using System;

/// <summary>
/// カードなど、参照したいシステムデータが格納されている
/// </summary>
public class SystemData
{
    /// <summary>
    /// キャラクター管理クラス
    /// </summary>
    public CharacterController characterController;

    public TriggerController triggerController;

    /// <summary>
    /// イニシャライズ
    /// データの初期設定など
    /// </summary>
    [Obsolete]
    public SystemData(string dataDir)
    {
        characterController = new CharacterController($"{dataDir}/characters");
        triggerController = new TriggerController($"{dataDir}/triggers");
    }
}