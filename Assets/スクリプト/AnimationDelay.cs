using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDelay : MonoBehaviour
{
    [SerializeField] float delayTime = 0;
    Animator anim;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= delayTime)
        {
            anim.enabled=true;
        }
    }
}
