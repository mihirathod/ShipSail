using UnityEngine;
using UnityEngine.Advertisements;
public class AdsManager : MonoBehaviour , IUnityAdsListener
{
    private string PlaystoreID = "4155905";
    private string AppleId = "4155904";
    private string Instertial = "video";
    private string RewardedVideo = "rewardedVideo";
    public bool IsPlayStore;
    public bool  IstestAD;


    private void Start()
    {
        Advertisement.AddListener(this);
        InitializeAD();
    }
     private void InitializeAD()
    {
        if (IsPlayStore)
        {
            Advertisement.Initialize(PlaystoreID, IstestAD);
            return;
        }
        Advertisement.Initialize(AppleId, IstestAD);
    }
    public void InstertialAD()
    {
        if (!Advertisement.IsReady(Instertial))
        {
            return;
        }
        Advertisement.Show(Instertial);
        Time.timeScale = 0f;

    }
    public void Reward()
    {
        if (!Advertisement.IsReady(RewardedVideo))
        {
            return;
        }
        Advertisement.Show(RewardedVideo);
        Time.timeScale = 0f;
        
    }

    public void OnUnityAdsReady(string placementId)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidError(string message)
    {
       // throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        //throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        switch (showResult)
        {
            case ShowResult.Failed:
                break;
            case ShowResult.Skipped:
                break;
            case ShowResult.Finished:
                if(placementId == RewardedVideo) { Debug.Log("reward");}
                if(placementId ==Instertial) 
                { Debug.Log("Forece");
                    
                }
                break;
         
        }
        Time.timeScale = 1f;
        
    }
}

