using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WallSwitch : MonoBehaviour
{
    [SerializeField] GameObject[] walls;
    float count = 0;
    [SerializeField] float interval = 0;
    // Start is called before the first frame update
    void Start()
    {
        //walls = GameObject.FindGameObjectsWithTag("SwitchWall");
    }
    void Update()
    {
        count +=Time.deltaTime;
        if( interval < count)
        {
            walls.ToList().ForEach(go => go.SetActive(!go.activeSelf));
            count = 0;
        }
    }
}
