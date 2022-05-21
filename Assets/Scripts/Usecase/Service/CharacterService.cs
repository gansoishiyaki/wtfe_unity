using System;
using Domain;
using IRepository;

/// <summary>
/// キャラクターサービス
/// </summary>
public class CharacterService : ICharacterService
{
    private IResourceRepository resource;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="resource"></param>
    public CharacterService(IResourceRepository resource)
    {
        this.resource = resource;
    }

    Character ICharacterService.Create(string id)
    {
        var rChara = resource.Characters()[id];
        var chara = new Character();

        // 各パラメータの初期値取得
        chara.id = id;
        chara.level = rChara.level;
        chara.name = rChara.name;
        chara.maxhp = rChara.maxhp;
        chara.hp = rChara.maxhp;
        chara.atk = rChara.atk;
        chara.def = rChara.def;
        chara.teh = rChara.teh;
        chara.spd = rChara.spd;
        chara.luk = rChara.luk;
        chara.move = rChara.move;
        chara.conducting = rChara.conducting;

        // TODO: Storageに登録する

        return chara;
    }

    Character ICharacterService.Get(string id)
    {
        throw new NotImplementedException();
    }
}
