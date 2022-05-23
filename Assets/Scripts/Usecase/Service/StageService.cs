using Domain;
using Domain.Converter;
using IRepository;

public class MissionService : IMissionService
{
    private IResource resource;
    private IRepository.DataStore.ICharacter storeChara;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="resource"></param>
    /// <param name="storeChara"></param>
    public MissionService(
        IResource resource,
        IRepository.DataStore.ICharacter storeChara
    )
    {
        this.resource = resource;
        this.storeChara = storeChara;
    }

    Mission IMissionService.Get(string id)
    {
        var res = resource.Missions()[id];
        return res.ToModel(resource, storeChara);
    }

    Stage IMissionService.Stage(string id, int num)
    {
        var res = resource.Missions()[id];
        var stage = res.stages[num];
        return stage.ToModel(resource, storeChara);
    }
}