using UnityEngine;
using Domain;

/// <summary>
/// チーム
/// </summary>
public class StageTeamViewModel : BaseViewModel
{
    // private
    private StageTeam model;
    private StageViewModel parent;

    public int group_id
    {
        get { return model.group_id; }
    }

    public StageTeamViewModel(StageTeam model, StageViewModel parent)
    {
        this.model = model;
        this.parent = parent;
    }

    /// <summary>
    /// キャラクター生成など
    /// </summary>
    public void SetUp()
    {
        model.characters.ForEach(character =>
        {
            // キャラクターobj生成
            var charaObj = Resources.Load<GameObject>($"{Config.FieldObjDir}/character");
            charaObj = createChild(charaObj);

            var charaComponent = charaObj.GetComponent<Component.StageCharacterComponent>();
            var charaViewModel = new StageCharacterViewModel(character, this);
            charaComponent.setViewModel(charaViewModel);

            parent.AddCharacter(charaViewModel);
        });
    }
}