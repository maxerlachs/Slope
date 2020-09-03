using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pous : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject all;

    public void Paus ()
    {
        if (GameIsPaused)
        {
            pauseMenuUI.SetActive(false);
            all.SetActive(true);

            GameIsPaused = false; 
            Time.timeScale = 1f;
        } else
        {
            pauseMenuUI.SetActive(true);
            all.SetActive(false);

            GameIsPaused = true;
            Time.timeScale = 0f;
        }
    }
}
