using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Domain;


public class StageViewModel
{
    // delegate
    public delegate GameObject CreateChild(GameObject obj);
    public CreateChild createChild;

    // Domain
    private Mission mission;
    private Stage model;

    // GameObject
    private GameObject stageObj;

    // Start is called before the first frame update
    public StageViewModel()
    {
        var missionService = Main.Get.Registory.mission;
        mission = Temporary.Main.mission;
        model = missionService.Stage(mission.id, Temporary.Main.stageNum);
    }

    /// <summary>
    /// ステージ生成
    /// </summary>
    /// <returns></returns>
    public void SetUp()
    {
        // ステージ作成
        var obj = Resources.Load<GameObject>(model.mapFile);
        stageObj = createChild(obj);
    }
}
