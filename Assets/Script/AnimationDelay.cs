using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDelay : MonoBehaviour
{
    [SerializeField] float delayTime = 0;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
        StartCoroutine(AnimationOn());
    }

    //指定した秒数だけ遅らせて再生
    IEnumerator AnimationOn()
    {
        yield return new WaitForSeconds(delayTime);
        anim.enabled = true;
    }
}
