using UnityEngine;

public static class Dummy
{
    public static void CreateDummyData(Registory registory)
    {
        var chara = registory.chara;
        chara.Create("hyrain");

        var hyrain = registory.chara.Get("hyrain");
        Debug.Log(hyrain);
    }
}
