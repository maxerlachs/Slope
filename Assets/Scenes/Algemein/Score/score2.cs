using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score2 : MonoBehaviour
{
    public Text textBox;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("LastScore") > PlayerPrefs.GetInt("Haighscore")) 
        { 
            PlayerPrefs.SetInt("Haighscore", PlayerPrefs.GetInt("LastScore"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text = Mathf.Round(PlayerPrefs.GetInt("LastScore")).ToString();
    }
}
