using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DDOL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //DDOL‚ª‚Â‚¢‚Ä‚¢‚é‚à‚Ì‚ğ’T‚·
        int numMusicPlayers = FindObjectsOfType<DDOL>().Length;
        if (numMusicPlayers > 1)
        {
            //‚Q‚ÂˆÈã‚ ‚Á‚½‚ç”j‰ó
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
