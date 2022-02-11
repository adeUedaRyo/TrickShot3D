using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WallSwitch : MonoBehaviour
{
    [SerializeField] GameObject[] walls;
    // Start is called before the first frame update
    void Start()
    {
        //walls = GameObject.FindGameObjectsWithTag("SwitchWall");
    }
    private void OnTriggerEnter(Collider other)
    {
        walls.ToList().ForEach(go => go.SetActive(!go.activeSelf));
    }
}
