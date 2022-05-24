using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Component
{
    public class TeamComponent : MonoBehaviour
    {
        private StageTeamViewModel viewModel;

        /// <summary>
        /// viewModelのセット
        /// 初期処理
        /// </summary>
        /// <param name="viewModel"></param>
        public void setViewModel(StageTeamViewModel viewModel)
        {
            this.viewModel = viewModel;

            // delegate
            viewModel.createChild = delegate (GameObject obj, GameObject parent)
            {
                // 親指定がない場合はStageの子
                if (!parent)
                    parent = gameObject;
                return Instantiate(obj, parent.transform);
            };

            viewModel.SetUp();
        }
    }
}
