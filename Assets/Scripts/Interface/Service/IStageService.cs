using Domain;

/// <summary>
/// ステージを管理するサービス
/// </summary>
public interface IStageService
{
    /// <summary>
    /// ステージ開始時に必要な情報を取得する
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Stage Detail(string id);
}