using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdScript : MonoBehaviour
{
    public AdScript2 coonsent;
   
    private int chekc;
    // Use this for initialization
    void Start()
    {
        string appId = "ca-app-pub-1904664762917518~5408993838";
        MobileAds.Initialize(appId);
        chekc = coonsent.Getconsent();
        Debug.Log("consent adscript" + chekc);
       
            showBannerAd();
            

    }

    private void showBannerAd()
    {
        string adID = "ca-app-pub-1904664762917518/1066424146";

        //***For Testing in the Device***
        //AdRequest request = new AdRequest.Builder()
        //.AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
        // .AddTestDevice("2077ef9a63d2b398840261c8221a0c9b")  // My test device.
        //.Build();

        //***For Production When Submit App***
        if (chekc == 1)
        {
            AdRequest request = new AdRequest.Builder().AddExtra("npa", "1").Build();

            BannerView bannerAd = new BannerView(adID, AdSize.SmartBanner, AdPosition.Bottom);
            bannerAd.LoadAd(request);
            Debug.Log("nonper");
        }
        else
        {
            AdRequest request = new AdRequest.Builder().Build();

            BannerView bannerAd = new BannerView(adID, AdSize.SmartBanner, AdPosition.Bottom);
            bannerAd.LoadAd(request);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}