using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatStageSelect : MonoBehaviour
{
    int count = 0;
    [SerializeField] GameObject cat;
    
    public void Count()
    {
        count += 1;
    }

    public void Cat()
    {
        if(count >= 3)
        {
            cat.SetActive(true);
        }
        else
        {
            count = 0;
        }
    }

}
