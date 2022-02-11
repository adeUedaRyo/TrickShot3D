using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    Rigidbody pRb;
    [SerializeField] float power = 1;
    float pDrag = 0;
    [SerializeField] float bDrag = 1;
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
            pRb = other.GetComponent<Rigidbody>();
            pDrag = pRb.drag;
            pRb.drag = bDrag;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            
            Vector3 i = other.transform.position - this.transform.position ;
            pRb.AddForce(i * power, ForceMode.Force);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        pRb.drag = pDrag;
    }
}
