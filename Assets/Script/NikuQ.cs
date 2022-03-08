using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NikuQ : MonoBehaviour
{
    Rigidbody rb;
    float time;
    [SerializeField] GameObject explosion;
    GameManager gM;
    [SerializeField] float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        gM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if(this.transform.position.z > 30 || this.transform.position.z < -30)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

        Instantiate(explosion, other.transform.position, other.transform.rotation);
        Destroy(other.gameObject);
        Invoke("GameOver", 1);
    }
    void GameOver()
    {
        gM.Bad();
    }
}
