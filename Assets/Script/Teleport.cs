using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] GameObject portal;
    bool telep = false;
    Teleport otherTelepo;

    // Start is called before the first frame update
    void Start()
    {
        otherTelepo = portal.GetComponent<Teleport>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !telep)
        {
            other.transform.position = portal.transform.position;
            otherTelepo.telep = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        telep = false;
    }

}