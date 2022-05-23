using Domain;

/// <summary>
/// ステージを管理するサービス
/// </summary>
public interface IMissionService
{
    /// <summary>
    /// ミッションの情報を取得する
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Mission Get(string id);

    /// <summary>
    /// ステージを取得する
    /// </summary>
    /// <param name="id"></param>
    /// <param name="num"></param>
    /// <returns></returns>
    public Stage Stage(string id, int num);
}