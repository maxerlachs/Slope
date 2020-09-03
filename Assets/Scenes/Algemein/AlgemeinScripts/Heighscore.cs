using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heighscore : MonoBehaviour
{

    public GameObject speed;
    public GameObject AirBallon;
    public Vector3 AirBallonPos;
    private float Distanse;
    public Text textBox;
    private int round = -1;
    private int Hundretscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distanse = speed.transform.position.z - 0;
        if (Distanse < round)
        {
            textBox.text = Mathf.Round(round * -1).ToString() + "M";
            PlayerPrefs.SetInt("LastScore", round * -1);
            round = round -1;
        }


        if (Distanse < Hundretscore)
        {
            SpawnAirBallon();
        }
    }

    void SpawnAirBallon()
    {
        Hundretscore = Hundretscore - 100;
        AirBallonPos = new Vector3(-2, 5, Hundretscore);
        Instantiate(AirBallon, AirBallonPos, Quaternion.identity);
    }
}
