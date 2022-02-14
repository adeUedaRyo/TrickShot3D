using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierAnim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale += new Vector3(0.5f * Time.deltaTime, 0.5f * Time.deltaTime, 0.5f * Time.deltaTime);
        if (this.transform.localScale.x >= 1)
        {
            this.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        }
    }
}
