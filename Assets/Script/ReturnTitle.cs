using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnTitle : MonoBehaviour
{
    [SerializeField] string sceneName;
    public void StageChange()
    {
        //�w�肳�ꂽ���O�̃V�[�����Ăяo��
        SceneManager.LoadScene(sceneName);
    }
    public void BgmChange()
    {
        GameObject BGM = GameObject.Find("BGM");
        Destroy(BGM);
    }
}
