using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DDOL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //DDOL�����Ă�����̂�T��
        int numMusicPlayers = FindObjectsOfType<DDOL>().Length;
        if (numMusicPlayers > 1)
        {
            //�Q�ȏ゠������j��
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
