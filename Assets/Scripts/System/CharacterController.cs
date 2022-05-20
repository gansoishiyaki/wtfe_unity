using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Model.Character;

/// <summary>
/// カードを管理するクラス
/// </summary>
public class CharacterController
{
    /// <summary>
    /// カードリスト
    /// </summary>
    public Dictionary<string, Base> models;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    [Obsolete]
    public CharacterController(string path)
    {
        models = SetCharacterds(path);
        Debug.Log($"Success Load Character: {models.Count} Count");
    }

    [Obsolete]
    private Dictionary<string, Base> SetCharacterds(string path)
    {
        var json = Resources.Load(path) as TextAsset;
        var serializer = JsonUtility.FromJson<Serializer>(json.text);

        return serializer.characters.ToDictionary(chara => chara.id);
    }
}
