using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTrap : MonoBehaviour
{
    [SerializeField] float power = 1;
    Rigidbody rB;
    [SerializeField] Transform trap;
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
        if (other.tag == "Player")
        {
            rB =other.GetComponent<Rigidbody>();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        Vector3 a = this.transform.position - trap.position;
        rB.AddForce(a * power, ForceMode.Force);
    }
}
