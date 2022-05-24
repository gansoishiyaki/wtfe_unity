using Domain;

/// <summary>
/// プレイヤーが所持するキャラクターに関するサービス
/// </summary>
public interface ICharacterService
{
    /// <summary>
    /// キャラクターの取得
    /// </summary>
    /// <param name="id">キャラクターid</param>
    /// <returns></returns>
    public Character Get(string id);

    /// <summary>
    /// キャラクター生成
    /// </summary>
    /// <param name="id">キャラクターid</param>
    public void Create(string id);
}
