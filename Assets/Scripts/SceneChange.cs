using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] 
    private string sceneName = default;

    public void Change()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Change(string name)
    {
        SceneManager.LoadScene(name);
    }
}
