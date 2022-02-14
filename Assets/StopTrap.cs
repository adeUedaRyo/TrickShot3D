using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTrap : MonoBehaviour
{
    Rigidbody rB;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        rB = other.GetComponent<Rigidbody>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player") 
        {
            time += Time.deltaTime;
        }
        if (time >= 0.1 )
        {
            rB.drag = 100;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        time = 0;
    }

}
