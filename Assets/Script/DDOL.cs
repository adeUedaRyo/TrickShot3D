using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DDOL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //DDOLがついているものを探す
        int numMusicPlayers = FindObjectsOfType<DDOL>().Length;
        if (numMusicPlayers > 1)
        {
            //２つ以上あったら破壊
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    public void Destroy()
    {
        Destroy(this.gameObject);
    }
}
