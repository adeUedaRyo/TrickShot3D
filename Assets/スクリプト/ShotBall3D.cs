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
    // Start is called before the first frame update
    void Start()
    {
        pRb = GetComponent<Rigidbody>();
        aLine = GetComponent<LineRenderer>();
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
        if (shotC  < 1)
        {
            //打つ前
            switch (cameraChange % 4)
            {
                case 0:
                    camera1.SetActive(true);
                    camera2.SetActive(false);
                    camera3.SetActive(false);
                    camera4.SetActive(false);
                    break;
                case 1:
                    camera1.SetActive(false);
                    camera2.SetActive(true);
                    camera3.SetActive(false);
                    camera4.SetActive(false);
                    break;
                case 2:
                    camera1.SetActive(false);
                    camera2.SetActive(false);
                    camera3.SetActive(true);
                    camera4.SetActive(false);
                    break;
                case 3:
                    camera1.SetActive(false);
                    camera2.SetActive(false);
                    camera3.SetActive(false);
                    camera4.SetActive(true);
                    break;
            }
        }
        else
        {
            //打った後
            switch (cameraChange % 4)
            {
                case 0:
                    camera1.SetActive(true);
                    camera2.SetActive(false);
                    camera3.SetActive(false);
                    camera4.SetActive(false);
                    break;
                case 1:
                    cameraChange += 1;
                    break;
                case 2:
                    camera1.SetActive(false);
                    camera2.SetActive(false);
                    camera3.SetActive(true);
                    camera4.SetActive(false);
                    break;
                case 3:
                    camera1.SetActive(false);
                    camera2.SetActive(false);
                    camera3.SetActive(false);
                    camera4.SetActive(true);
                    break;
            }
        }
        

        //打つよ
        if (Input.GetKeyDown(KeyCode.Space) && shotC <1)
        {
            Shot();
            shotC += 1;
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
        Vector3 i = this.transform.position - cue.transform.position;
        Vector3 i2 = new Vector3(i.x, 0, i.z);
        Vector3 force = power * power2 * i2;
        pRb.AddForce(force,ForceMode.Impulse);
        Destroy(cue);
        Destroy(powerText);
    }
}
