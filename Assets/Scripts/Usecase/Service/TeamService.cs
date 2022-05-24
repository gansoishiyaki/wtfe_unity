using System.Collections.Generic;
using Domain;
using Domain.Converter;
using IRepository;
using IRepository.DataStore;

public class TeamService : ITeamService
{
    private IResource resource;
    private ICharacter storeCharaRepo;
    private ITeam store;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="resource"></param>
    /// <param name="storeChara"></param>
    public TeamService(
        IResource resource,
        ICharacter storeChara,
        ITeam store
    )
    {
        this.store = store;
        this.resource = resource;
        storeCharaRepo = storeChara;
    }

    Team ITeamService.Get(string id)
    {
        var storeStage = store.Get(id);
        return storeStage.ToModel(resource, storeCharaRepo);
    }

    void ITeamService.SetCharacters(string id, List<string> characters)
    {
        var storeTeam = store.Exist(id) ? store.Get(id) : new DataStore.Team();
        storeTeam.id = id;
        storeTeam.characters = characters;
        store.Set(storeTeam);
    }

    void ITeamService.SetName(string id, string name)
    {
        var storeTeam = store.Exist(id) ? store.Get(id) : new DataStore.Team();
        storeTeam.name = name;
        store.Set(storeTeam);
    }
}