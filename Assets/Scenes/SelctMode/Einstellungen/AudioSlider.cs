using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSlider : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolum (float volum)
    {
        PlayerPrefs.SetFloat("Volume", volum);
    }
    public void Update()
    {
        audioMixer.SetFloat("Volume", PlayerPrefs.GetFloat("Volume"));
    }
}
