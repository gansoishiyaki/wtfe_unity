using System.Collections.Generic;
using Domain;

/// <summary>
/// ステージを管理するサービス
/// </summary>
public interface ITeamService
{
    /// <summary>
    /// ステージを取得する
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Team Get(string id);

    /// <summary>
    /// チームキャラクターの設定
    /// </summary>
    /// <param name="id"></param>
    /// <param name="num"></param>
    /// <returns></returns>
    public void SetCharacters(string id, List<string> characters);

    /// <summary>
    /// チーム名の設定
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    public void SetName(string id, string name);
}