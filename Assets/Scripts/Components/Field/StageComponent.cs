using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Component
{
    /// <summary>
    /// ステージ操作
    /// </summary>
    public class StageComponent : MonoBehaviour
    {
        private StageViewModel viewModel;

        // Start is called before the first frame update
        void Start()
        {
            viewModel = new StageViewModel();

            // delegate
            viewModel.createChild = delegate (GameObject obj, GameObject parent)
            {
                // 親指定がない場合はStageの子
                if(!parent)
                    parent = gameObject;
                return Instantiate(obj, parent.transform);
            };

           viewModel.SetUp();
        }
    }
}
