using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnTitle : MonoBehaviour
{
    [SerializeField] string sceneName;
    public void StageChange()
    {
        //指定された名前のシーンを呼び出す
        SceneManager.LoadScene(sceneName);
    }
    public void BgmChange()
    {
        GameObject BGM = GameObject.Find("BGM");
        Destroy(BGM);
    }
}
