using System.Collections.Generic;
using UnityEngine;

public static class Dummy
{
    public static void CreateDummyData(Registory registory)
    {
        var chara = registory.chara;
        chara.Create("hyrain");

        registory.chara.Get("hyrain");

        registory.team.SetCharacters("test", new List<string> { "hyrain" });
        registory.team.SetName("test", "テストチーム");
        Temporary.Main.team = registory.team.Get("test");

        var testMission = registory.mission.Get("test");
        Temporary.Main.mission = testMission;
    }
}
