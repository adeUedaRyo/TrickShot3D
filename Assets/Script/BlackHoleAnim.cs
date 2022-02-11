using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleAnim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //縮んで、リセット
        this.transform.localScale -= new Vector3(1.5f * Time.deltaTime,1.5f * Time.deltaTime, 1.5f * Time.deltaTime);
        if(this.transform.localScale.x <1)
        {
            this.transform.localScale = new Vector3(4.5f, 4.5f, 4.5f);
        }
    }
}
