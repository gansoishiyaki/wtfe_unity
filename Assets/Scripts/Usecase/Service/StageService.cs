using Domain;
using Domain.Converter;
using IRepository;

public class MissionService : IMissionService
{
    private IResource resource;
    private IRepository.DataStore.ICharacter storeChara;
    private IRepository.DataStore.ITeam storeTeam;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="resource"></param>
    /// <param name="storeChara"></param>
    public MissionService(
        IResource resource,
        IRepository.DataStore.ICharacter storeChara,
        IRepository.DataStore.ITeam storeTeam
    )
    {
        this.resource = resource;
        this.storeChara = storeChara;
        this.storeTeam = storeTeam;
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
        var team = storeTeam.Get(Temporary.Main.team.id);
        return stage.ToModel(resource, storeChara, team);
    }
}