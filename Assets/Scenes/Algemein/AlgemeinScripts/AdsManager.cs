using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour, IUnityAdsListener
{
public string placement = "SecondTry";


    public void SecondTry ()
    {
        Advertisement.Initialize("3798837", true);

        if(Advertisement.IsReady(placement))
        {
                Advertisement.Show(placement);
        }          

        
    }


    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
       if (showResult ==ShowResult.Finished)
        {

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
}
