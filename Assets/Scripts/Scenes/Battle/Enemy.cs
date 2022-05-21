using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Map.Battle
{
    public class Enemy : Character
    {
        // Start is called before the first frame update
        void Start()
        {
            var transform = GetComponent<Transform>();
            Debug.Log(transform.position);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
