using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Username : MonoBehaviour
{
    public string username;
    public GameObject inputField;
    public GameObject usernameTap;
    public void AddUsername()
    {
        PlayerPrefs.SetInt("Haighscore", 0);
        if (inputField.GetComponent<Text>().text.Length > 1)
        {
             username = inputField.GetComponent<Text>().text;
            PlayerPrefs.SetString("Username", username);
            usernameTap.SetActive(false);
        }
       
    }
}
