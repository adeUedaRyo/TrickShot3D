using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageStart : MonoBehaviour
{
    [SerializeField] string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StageChange()
    {
        //�w�肳�ꂽ���O�̃V�[�����Ăяo��
        SceneManager.LoadScene(sceneName);
    }
}
