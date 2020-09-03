using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadHardGame : MonoBehaviour
{
    public void LoadeHardGame()
    {
        SceneManager.LoadScene("Hard");
        Time.timeScale = 1f;
    }
}
