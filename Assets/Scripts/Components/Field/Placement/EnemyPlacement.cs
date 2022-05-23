using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlacement : MonoBehaviour
{
    public CharacterEnum characterEnum;

    [SerializeField, Range(1, 4)]
    public int priority = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
