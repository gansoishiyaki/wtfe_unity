using System.Collections.Generic;
namespace Domain.Converter
{
    /// <summary>
    /// ステージ変換クラス
    /// </summary>
    static class MissionConverter
    {
        public static Mission ToModel(
            this Resource.Mission resourceMission,
            IRepository.IResource resource,
            IRepository.DataStore.ICharacter storeChara
        )
        {
            var mission = new Mission();
            mission.id = resourceMission.id;
            mission.name = resourceMission.name;
            return mission;
        }
    }
}