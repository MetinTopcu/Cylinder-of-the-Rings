using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.Purchasing;
using UnityEngine.UI;
using System.Collections.Generic;

public class Admob : MonoBehaviour, IStoreListener
{

    public bool truemi1 = true;
    public bool truemi2 = true;
    public bool truemi3 = true;

    public bool reward1 = false;
    public bool reward2 = false;
    public bool reward3 = false;

    //Banner
    private BannerView bannerView;
    //Rewarded
    private RewardedAd rewardedAd;
    private RewardedAd rewardedAd1;
    private RewardedAd rewardedAd2;
    //İnsterstitial
    private InterstitialAd interstitial;

    public static Admob adm;

    private Puan puanim;

    //No Ads
    private static IStoreController m_StoreController;
    private static IExtensionProvider m_StoreExtensionProvider;

    public static string noads_str = "noads";

    public static string kProductNameGooglePlaySubscription = "com.metin.ringsofcylinders";

    public int reklamokemi = 0;

    private GameObject noads_button;

    [SerializeField]
    private List<GameObject> noadsclose;

    void Start()
    {
        if (m_StoreController == null)
        {
            InitializePurchasing();
        }

        puanim = GameObject.FindGameObjectWithTag("puan").GetComponent<Puan>();
        adm = this;

        noads_button = GameObject.FindGameObjectWithTag("noads");
        reklamokemi = PlayerPrefs.GetInt("reklamokemi5", 0);
        if (reklamokemi == 0)
        {
            MobileAds.Initialize(initStatus => { });

            RequestBanner();
            //RequestInterstitial();
            RequestRewarded();
            RequestRewarded1();
            RequestRewarded2();
        }
        else if (reklamokemi == 1)
        {
            noadsclose[0].SetActive(false);
            noadsclose[1].SetActive(false);
            noadsclose[2].SetActive(false);
            noadsclose[3].SetActive(false);
            noadsclose[4].SetActive(false);
            noadsclose[5].SetActive(false);
            noadsclose[6].SetActive(false);

            noads_button.SetActive(false);
            gameObject.SetActive(false);
        }
    }
    #region Banner
    public void RequestBanner()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3025903384058604/6038809791";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
            string adUnitId = "unexpected_platform";
#endif
        bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
    }
    #endregion
    #region Rewarded
    public void RequestRewarded()
    {
        string adUnitId = "ca-app-pub-3025903384058604/9643012887";
        rewardedAd = new RewardedAd(adUnitId);
        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        AdRequest request = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(request);
        reward1 = false;
    }
    public void RequestRewarded1()
    {

        string adUnitId1 = "ca-app-pub-3025903384058604/7732025210";
        rewardedAd1 = new RewardedAd(adUnitId1);
        rewardedAd1.OnUserEarnedReward += HandleUserEarnedReward1;
        AdRequest request1 = new AdRequest.Builder().Build();
        rewardedAd1.LoadAd(request1);
        reward2 = false;
    }
    public void RequestRewarded2()
    {
        string adUnitId2 = "ca-app-pub-3025903384058604/6418943544";
        rewardedAd2 = new RewardedAd(adUnitId2);
        rewardedAd2.OnUserEarnedReward += HandleUserEarnedReward2;
        AdRequest request2 = new AdRequest.Builder().Build();
        rewardedAd2.LoadAd(request2);
        reward3 = false;
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        //ödül

        Camera.main.transform.position = Camera.main.transform.position - new Vector3 (0f,0f,5f);


        UIManager.ui_m.CloseGameOverUI();
        UIManager.ui_m.OpenGamePanel();

        int playernumber = PlayerPrefs.GetInt("getPlayers", 0);
        switch (playernumber)
        {
            case 0:
                GameManager.gm.putOn1();
                break;
            case 1:
                GameManager.gm.putOn2();
                break;
            case 2:
                GameManager.gm.putOn3();
                break;
            case 3:
                GameManager.gm.putOn4();
                break;
            case 4:
                GameManager.gm.putOn5();
                break;
            case 5:
                GameManager.gm.putOn6();
                break;
            case 6:
                GameManager.gm.putOn7();
                break;
            case 7:
                GameManager.gm.putOn8();
                break;
            case 8:
                GameManager.gm.putOn9();
                break;
            default:
                break;
        }
        UIManager.ui_m.SetPlayerHealth(10f);
        GameManager.gm.startgame = true;
        GameManager.gm.oyundevam = true;
        truemi1 = false;
        reward1 = true;
    }
    public void HandleUserEarnedReward1(object sender, Reward args)
    {
        //ödül
        puanim.puan += 100;
        puanim.satinAl();
        truemi2 = false;
        reward2 = true;
    }
    public void HandleUserEarnedReward2(object sender, Reward args)
    {
        //ödül
        puanim.wood += 200;
        puanim.buyWood();
        truemi3 = false;
        reward3 = true;
    }
    public void openRewarded()
    {
        if (truemi1)
        {
            if (rewardedAd.IsLoaded())
            {
                rewardedAd.Show();
            }
        }
    }


    public void openGoldRewarded()
    {
        if (truemi2)
        {
            if (rewardedAd1.IsLoaded())
            {
                rewardedAd1.Show();
            }
        }
    }

    public void openWoodRewarded()
    {
        if (truemi3)
        {
            if (rewardedAd2.IsLoaded())
            {
                rewardedAd2.Show();
            }
        }
    }
    #endregion

    #region Interstitial
    public void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3025903384058604/3185140072";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
    }
    public void OpenInterstitial()
    {

        if (GameManager.gm.interstitial >= 3)
        {

            if (interstitial.IsLoaded())
            {
                interstitial.Show();
            }
            GameManager.gm.interstitial = 0;
        }
    }
    #endregion

    #region NoAds
    public void InitializePurchasing()
    {
        if (IsInitialized())
        {
            return;
        }

        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        builder.AddProduct(noads_str, ProductType.NonConsumable);

        UnityPurchasing.Initialize(this, builder);
    }

    private bool IsInitialized()
    {
        return m_StoreController != null && m_StoreExtensionProvider != null;
    }

    public void ReklamKaldir()
    {
        BuyProductID(noads_str);
    }

    void BuyProductID(string productId)
    {
        if (IsInitialized())
        {
            Product product = m_StoreController.products.WithID(productId);

            if (product != null && product.availableToPurchase)
            {
                m_StoreController.InitiatePurchase(product);
            }
            else
            {
            }
        }
        else
        {
        }
    }

    public void OnInitialized(IStoreController controller,IExtensionProvider extensions)
    {
        m_StoreController = controller;
        m_StoreExtensionProvider = extensions;
    }

    public void OnInitializeFailed(InitializationFailureReason error)
    {

    }

    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {
        if (string.Equals(args.purchasedProduct.definition.id,noads_str,System.StringComparison.Ordinal))
        {
            PlayerPrefs.SetInt("reklamokemi5", 1);
            noadsclose[0].SetActive(false);
            noadsclose[1].SetActive(false);
            noadsclose[2].SetActive(false);
            noadsclose[3].SetActive(false);
            noadsclose[4].SetActive(false);
            noadsclose[5].SetActive(false);
            noadsclose[6].SetActive(false);
            noadsclose[7].SetActive(false);

            noads_button.SetActive(false);
            bannerView.Destroy();
            gameObject.SetActive(false);
        }
        return PurchaseProcessingResult.Complete;
    }
    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {

    }
    #endregion

}

