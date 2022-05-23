using Domain;

/// <summary>
/// ステージを管理するサービス
/// </summary>
public interface IStageService
{
    public Stage Detail(string id);
}