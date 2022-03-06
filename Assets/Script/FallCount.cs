using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCount : MonoBehaviour
{
    [SerializeField] GameObject successP;
    GameManager gM;
    // Start is called before the first frame update
    void Start()
    {
        gM =GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Target")
        {
            //ターゲットが落ちたら
            Instantiate(successP, new Vector3(this.transform.position.x, -1, this.transform.position.z), Quaternion.Euler(-90,0,0)) ;
            Invoke("Good",1.2f);
        }
        else if(other.tag == "Player")
        {
            //プレイヤーが落ちたら
            gM.Bad();
        }
    }
    void Good()
    {
        gM.Good();
        Destroy(GameObject.Find("Player Ball"));
    }
}
