using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public string sceneName;
    void OnEnable()
    {
        SceneManager.LoadScene(sceneName);
    }
}
