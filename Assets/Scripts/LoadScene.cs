using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadGameScene(string targetScene)
    {
        Debug.Log(targetScene);
        SceneManager.LoadScene(targetScene);
        
    }
}
