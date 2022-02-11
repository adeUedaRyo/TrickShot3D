using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    Rigidbody pRb;
    [SerializeField]Transform bH;
    [SerializeField]float power = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //プレイヤーが入ったら中心に引き寄せる
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            pRb = other.GetComponent<Rigidbody>();
            Vector3 i = bH.position - other.transform.position;
            pRb.AddForce(i*power,ForceMode.Force);
        }
    }
}
