using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void ChangeSceneTo(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
