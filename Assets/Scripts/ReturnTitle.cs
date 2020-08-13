using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnTitle : MonoBehaviour
{
    private SceneChange _sceneChange;
    
    private void Awake()
    {
        _sceneChange = gameObject.AddComponent<SceneChange>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            _sceneChange.Change("Title");
        }
    }
}
