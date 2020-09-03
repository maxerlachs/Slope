using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public GameObject mute;
    public void AudioOnOf()
    {
        if(PlayerPrefs.GetFloat("Volume") > -80)
        {
            PlayerPrefs.SetFloat("Volume", 0);
        }else
        {
            PlayerPrefs.SetFloat("Volume", -80);
        }
    }
    private void Update()
    {
        if(PlayerPrefs.GetFloat("Volume") == -80)
        {
            mute.SetActive(true);
        }
    }
}
