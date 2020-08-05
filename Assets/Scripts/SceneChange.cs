﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] 
    private string sceneName = default;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void Change()
    {
        SceneManager.LoadScene(sceneName);
    }
}
