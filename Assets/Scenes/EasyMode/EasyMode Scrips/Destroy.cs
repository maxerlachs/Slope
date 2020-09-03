using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Advertisements;

public class Destroy : MonoBehaviour, IUnityAdsListener
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
        }


    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            Move move = GameObject.Find("Speed").GetComponent<Move>();
            move.zahl = -2.5f;
            all.SetActive(true);
            GameOver.SetActive(false);
            Time.timeScale=1;
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
        Time.timeScale = 0;
    }
}
