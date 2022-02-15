using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    GameManager gM;
    // Start is called before the first frame update
    void Start()
    {
        gM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeStage()
    {
        gM.StageChange();
    }
}
