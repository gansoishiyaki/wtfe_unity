namespace Domain.Converter
{
    static class TeamConverter
    {
        public static Team ToModel(
            this DataStore.Team store,
            IRepository.IResource resource,
            IRepository.DataStore.ICharacter storeCharaRepo
        )
        {
            var team = new Team();
            team.id = store.id;
            team.name = store.name;
            team.characters = store.characters.ConvertAll(
                id => {
                    var storeChara = storeCharaRepo.Get(id);
                    var resoureChara = resource.Characters()[id];
                    return storeChara.ToModel(resoureChara);
                });

            return team;
        }
    }
}