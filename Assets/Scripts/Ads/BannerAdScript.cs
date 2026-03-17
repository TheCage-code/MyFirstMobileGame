using UnityEngine;
using GoogleMobileAds.Api;
using System.Collections;

public class BannerAdScript : MonoBehaviour
{
    private BannerView bannerView;
    private string bannerId = "ca-app-pub-3940256099942544/6300978111";
    public static BannerAdScript instance;
   
    private void Awake()
    {
      if  (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        RequestBanner();
        StartCoroutine(CloseIt());  
    }

    
    void Update()
    {
        
    }
    public void RequestBanner()
    {
        bannerView = new BannerView(bannerId, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest();
        bannerView.LoadAd(request);
    }
    public void HideBanner()
    {
        bannerView.Destroy();
    }
    IEnumerator CloseIt()
    {
        yield return new WaitForSeconds(5);
        HideBanner();
    }
}
