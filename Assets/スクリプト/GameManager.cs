﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int gameCount = 0;
    [SerializeField]GameObject success;
    [SerializeField]GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Good()
    {
        success.SetActive(true);
    }
    public void Bad()
    {
        Destroy(success);
        gameOver.SetActive(true);
    }

}
