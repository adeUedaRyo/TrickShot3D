using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject success;
    [SerializeField] GameObject gameOver;
    [SerializeField] string sceneName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //クリア時
    public void Good()
    {
        success.SetActive(true);
    }

    //ゲームオーバー
    public void Bad()
    {
        Destroy(success);
        gameOver.SetActive(true);
    }

    public void StageChange()
    {
        //指定された名前のシーンを呼び出す
        SceneManager.LoadScene(sceneName);
    }
}
