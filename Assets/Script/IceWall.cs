using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceWall : MonoBehaviour
{
    [SerializeField] Material[] material;
    [SerializeField]int hp = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp < 2)
        {
            this.GetComponent<MeshRenderer>().materials =material;
        }
        if (hp == 0)
        {
            Destroy( this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="Player")
        {
            hp--;
        }
    }
}
