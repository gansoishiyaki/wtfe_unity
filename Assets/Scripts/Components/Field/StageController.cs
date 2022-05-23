using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Component
{
    public class StageController : MonoBehaviour
    {
        private StageViewModel viewModel;

        // Start is called before the first frame update
        void Start()
        {
            viewModel = new StageViewModel();

            // delegate
            viewModel.createChild = delegate (GameObject obj)
            {
                return Instantiate(obj, gameObject.transform);
            };

           viewModel.SetUp();
        }
    }
}
