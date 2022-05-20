using System;
using System.Collections.Generic;
using UnityEngine;
using Model.Trigger;
using System.Linq;

/// <summary>
/// トリガーを管理するクラス
/// </summary>
public class TriggerController
{
    /// <summary>
    /// カードリスト
    /// </summary>
    public Dictionary<string, Base> models;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    [Obsolete]
    public TriggerController(string path)
    {
        models = SetModels(path);
    }

    [Obsolete]
    private Dictionary<string, Base> SetModels(string path)
    {
        var json = Resources.Load(path) as TextAsset;
        var serializer = JsonUtility.FromJson<Serializer>(json.text);

        return serializer.triggers.ToDictionary(trigger => trigger.id);
    }
}
