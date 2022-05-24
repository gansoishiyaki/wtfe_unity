using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Domain;

/// <summary>
/// ステージ
/// </summary>
public class StageViewModel : BaseViewModel
{
    // Domain
    private Mission mission;
    private Stage model;

    // ViewModels
    private List<StageTeamViewModel> teams;
    private List<StageCharacterViewModel> characters = new List<StageCharacterViewModel>();

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public StageViewModel()
    {
        var missionService = Main.Get.Registory.mission;
        mission = Temporary.Main.mission;
        model = missionService.Stage(mission.id, Temporary.Main.stageNum);
    }

    /// <summary>
    /// ステージ生成
    /// </summary>
    public void SetUp()
    {
        // ステージ作成
        var stageObj = Resources.Load<GameObject>(model.mapFile);
        stageObj = createChild(stageObj);

        var teamsObj = Resources.Load<GameObject>($"{Config.FieldObjDir}/teams");
        teamsObj = createChild(teamsObj);

        // チーム生成
        teams = model.teams.ConvertAll(team =>
        {
            var objName = team.isPlayer ? "Player" : "OtherTeam";
            var teamObj = new GameObject(objName);
            teamObj = createChild(teamObj, teamsObj);

            // 生成したオブジェクトにコントローラーをアタッチして
            // viewModelをセットする
            var teamComponent = teamObj.AddComponent<Component.TeamComponent>();
            var stageTeam = new StageTeamViewModel(team, this);
            teamComponent.setViewModel(stageTeam);

            // 操作可能チームの場合、プレイヤー設定をする
            if (team.isPlayer)
                Temporary.Main.playerTeam = team;

            return stageTeam;
        });
    }

    /// <summary>
    /// 生成したキャラクターのセット
    /// </summary>
    /// <param name="character"></param>
    public void AddCharacter(StageCharacterViewModel character)
    {
        characters.Add(character);
    }
}
