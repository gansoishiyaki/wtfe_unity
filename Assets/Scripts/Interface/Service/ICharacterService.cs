using Domain;

/// <summary>
/// プレイヤーが所持するキャラクターに関するサービス
/// </summary>
public interface ICharacterService
{
    public Character Get(string id);
    public Character Create(string id);
}
