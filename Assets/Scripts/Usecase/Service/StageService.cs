using Domain;
using Domain.Converter;
using IRepository;

public class StageService : IStageService
{
    private IResource resource;
    private IRepository.DataStore.ICharacter storeChara;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="resource"></param>
    /// <param name="storeChara"></param>
    public StageService(
        IResource resource,
        IRepository.DataStore.ICharacter storeChara
    )
    {
        this.resource = resource;
        this.storeChara = storeChara;
    }

    Stage IStageService.Detail(string id)
    {
        var res = resource.Stages()[id];
        return res.ToModel(resource, storeChara);
    }
}