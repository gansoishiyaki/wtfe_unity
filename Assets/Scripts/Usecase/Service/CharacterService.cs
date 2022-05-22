using Domain;
using Domain.Converter;
using IRepository;

/// <summary>
/// 通常時のキャラクターに関するサービス
/// </summary>
public class CharacterService : ICharacterService
{
    private IResource resource;
    private IRepository.DataStore.ICharacter storeChara;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="resource"></param>
    public CharacterService(
        IResource resource,
        IRepository.DataStore.ICharacter store
    )
    {
        this.resource = resource;
        this.storeChara = store;
    }

    /// <summary>
    /// キャラクター生成
    /// </summary>
    /// <param name="id"></param>
    void ICharacterService.Create(string id)
    {
        var resourceCharacter = resource.Characters()[id];
        var storeCharacter = resourceCharacter.ToStore();

        storeChara.Add(storeCharacter);
    }

    /// <summary>
    /// キャラクター取得
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Character ICharacterService.Get(string id)
    {
        var storeCharacter = storeChara.Get(id);
        var resourceCharacter = resource.Characters()[id];

        return storeCharacter.ToModel(resourceCharacter);
    }
}
