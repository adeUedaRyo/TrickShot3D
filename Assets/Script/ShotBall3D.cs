using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotBall3D : MonoBehaviour
{
    [SerializeField] float rotateS = 1f;
    int cameraChange = 0;
    public int power = 5;
    public int power2 = 5;
    [SerializeField] GameObject cue;
    [SerializeField] GameObject camera1;
    [SerializeField] GameObject camera2;
    [SerializeField] GameObject camera3;
    [SerializeField] GameObject camera4;
    Rigidbody pRb;
    LineRenderer aLine = default;
    int lineC = 1;
    int shotC = 0;
    Vector3 rayCastHP;
    public Text powerText;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        pRb = GetComponent<Rigidbody>();
        aLine = GetComponent<LineRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //パワー変えるよ
        if (Input.GetKeyDown(KeyCode.DownArrow) && power > 1)
        {
            power -= 1;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && power < 10)
        {
            power += 1;
        }

        //パワー表示するよ
        powerText.text = power.ToString();

        //方向変えるよ
        float h = Input.GetAxisRaw("Horizontal");
        if (h !=0 && shotC < 1)
        {
            this.transform.Rotate(Vector3.up,h *rotateS *Time.deltaTime );
        }

        //カメラ替えるよ
        if (Input.GetKeyDown(KeyCode.LeftShift)) 
        {
            cameraChange += 1;
        }
        if (shotC  ==0)
        {
            //打つ前
            var activeIndex = (cameraChange % 4);
            camera1.SetActive(activeIndex == 0);
            camera2.SetActive(activeIndex == 1);
            camera3.SetActive(activeIndex == 2);
            camera4.SetActive(activeIndex == 3);

        }
        else
        {
            //打った後
            
            camera2.SetActive(false);
            var activeIndex = (cameraChange % 4);
            camera1.SetActive(activeIndex == 0 ||activeIndex ==1);
            if(activeIndex == 1)
            {
                cameraChange++;
            }
            camera3.SetActive(activeIndex == 2);
            camera4.SetActive(activeIndex == 3);

        }

        //構えるよ
        if(Input.GetKeyDown(KeyCode.Space) && shotC ==0)
        {
            anim.Play("Shot Set");
        }

        //打つよ
        if (Input.GetKeyUp(KeyCode.Space) && shotC ==0)
        {

            anim.Play("Shot");
            

        }

        //アシスト出すよ
        Ray ray = new Ray(this.transform.position, this.transform.right);
        RaycastHit hit;
        rayCastHP = this.transform.position + this.transform.right * 100;
        if (Physics.Raycast(ray, out hit))
        {
            rayCastHP = hit.point;
        }
        if (Input.GetKeyDown(KeyCode.LeftControl)) 
        {
            lineC += 1;
        }
        aLine.SetPosition(0, this.transform.position);
        aLine.SetPosition(1, rayCastHP);
        if (lineC % 2 == 0 && shotC < 1)
        {
            aLine.enabled = true;
        }
        else
        {
            aLine.enabled = false;
        }
    }
    //打った時呼ばれるよ
    void Shot()
    {
        shotC += 1;
        Vector3 i = this.transform.position - cue.transform.position;
        Vector3 i2 = new Vector3(i.x, 0, i.z);
        Vector3 force = power * power2 * i2;
        pRb.AddForce(force,ForceMode.Impulse);
        Destroy(cue);
        Destroy(powerText);
    }
}
