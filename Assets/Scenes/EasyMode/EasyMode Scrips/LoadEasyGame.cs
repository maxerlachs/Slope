using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEasyGame : MonoBehaviour
{
    public void LoadeEasyGame()
    {
        SceneManager.LoadScene("Easy Mode");
        Time.timeScale = 1f;
    }
}
