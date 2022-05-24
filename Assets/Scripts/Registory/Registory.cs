using System;
using IRepository;

/// <summary>
/// 各層の繋ぎを行うレジストリクラス
/// ベーシックパターン
/// Webの場合は別のレジストリを使う
/// </summary>
public class Registory
{
    public ICharacterService chara;
    public ITeamService team;
    public IMissionService mission;

    public Registory(
        IResource resource,
        DataStore.JSON.Handler store
    )
    {
        // repos
        var storeChara = new DataStore.JSON.CharacterRepository(store);
        var storeTeam = new DataStore.JSON.TeamRepository(store);

        // service
        chara = new CharacterService(resource, storeChara);
        team = new TeamService(resource, storeChara, storeTeam);
        mission = new MissionService(resource, storeChara, storeTeam);
    }
}
