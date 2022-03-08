using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchLight : MonoBehaviour
{
    Rigidbody rb;
    float time;
    [SerializeField] GameObject explosion;
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
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            time += Time.deltaTime;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            if (time > 0.1)
            {
                Instantiate(explosion, other.transform.position, other.transform.rotation);
                Destroy(other.gameObject);
                Invoke("GameOver",1);
            }
        }
    }
    void GameOver() 
    {
        gM.Bad();
    }
}
