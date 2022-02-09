using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchLight : MonoBehaviour
{
    Rigidbody rb;
    float time;
    [SerializeField] GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            rb =other.GetComponent<Rigidbody>();
            rb.drag = 15;
            time += Time.deltaTime;
            if(time > 1)
            {
                Instantiate(explosion,other.transform.position,other.transform.rotation);
                Destroy(other.gameObject);
            }
        }
    }

}
