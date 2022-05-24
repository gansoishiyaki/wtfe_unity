using System.Collections.Generic;
using UnityEngine;
using Domain;

/// <summary>
/// キャラクター
/// </summary>
public class StageCharacterViewModel : BaseViewModel
{
    // private
    private StageCharacter model;
    private StageTeamViewModel parent;

    // delegate
    public delegate void SetSprite(Sprite sprite);
    public SetSprite setSprite;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="model"></param>
    /// <param name="parent"></param>
    public StageCharacterViewModel(StageCharacter model, StageTeamViewModel parent)
    {
        this.model = model;
        this.parent = parent;
    }

    /// <summary>
    /// セットアップ
    /// </summary>
    public void SetUp()
    {
        // 初期位置指定
        var pos = new Vector2(model.initX, model.initY);
        setPositon(pos);

        var sprite = Resources.Load<Sprite>($"{Config.StageCharaDir}/{model.charaBase.id}");
        setSprite(sprite);
    }
}