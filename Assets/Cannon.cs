using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] GameObject nikuQ;
    [SerializeField] GameObject barrel;
    [SerializeField] float shot;
    float count;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(nikuQ, barrel.transform.position, barrel.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if(shot < count)
        {
            Instantiate(nikuQ, barrel.transform.position, barrel.transform.rotation);
            count = 0;
        }
    }
}
