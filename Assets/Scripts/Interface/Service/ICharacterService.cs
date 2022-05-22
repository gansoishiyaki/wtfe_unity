using Domain;

/// <summary>
/// プレイヤーが所持するキャラクターに関するサービス
/// </summary>
public interface ICharacterService
{
    public Character Get(string id);
    public void Create(string id);
}
