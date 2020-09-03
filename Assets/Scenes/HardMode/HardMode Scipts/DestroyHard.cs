using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Advertisements;

public class DestroyHard : MonoBehaviour, IUnityAdsListener
{
    public GameObject GameOver;
    public GameObject all;
    
    public string placement = "SecondTry";



    private void Start()
    {
        GameOver.SetActive(false);
        all.SetActive(true);
        Time.timeScale = 1;

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {            
            GameOver.SetActive(true);
            all.SetActive(false);

            Paused();
        }
    }

    public void SecondTry()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize("3798837", true);

        if (Advertisement.IsReady(placement))
        {
            Advertisement.Show(placement);
        }else
        {
            Debug.Log("Error");
        }


    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            MoveHard move = GameObject.Find("Speed").GetComponent<MoveHard>();
            move.zahl = -5;
            all.SetActive(true);
            GameOver.SetActive(false);
            Paused();
        }
    }

    public void OnUnityAdsDidStart(string placementId)
    {

    }

    public void OnUnityAdsReady(string placementId)
    {

    }
    public void OnUnityAdsDidError(string message)
    {

    }

    void Paused()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }else
        {
            Time.timeScale = 1;
        }
        
    }
}
