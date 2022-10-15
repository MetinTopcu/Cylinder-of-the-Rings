
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using UnityEngine.Purchasing;


public class GameManager : MonoBehaviour
{
    public bool bug = false;

    private GameObject destroyGameobject;

    public GameObject particleWood;
    public GameObject branch;
    public GameObject cylinder;

    private Renderer particlerenderer;
    private Renderer cylrenderer;
    private Renderer branchrenderer;

    [SerializeField]
    private Text taptofirslevel_text;
    [SerializeField]
    private Text taptosecondlevel_text;

    public int currentlevel = 1;
    public int curumlevel = 1;

    [HideInInspector]
    public bool isPlayerAlive = true;

    [HideInInspector]
    public bool gamePlay = true;

    public static GameManager gm;

    private GameObject konum;

    [SerializeField]
    private Transform playerStartPoint;

    [SerializeField]
    private CameraController cc;

    [SerializeField]
    private float difficulty = 1;

    public Image distanceimage;

    //mesafe
    private float waydistance = 0f;
    public bool startwood1 = false;
    //Shop
    public List<GameObject> buyButton;
    public List<GameObject> putonButton;
    public List<GameObject> goldimage;
    public List<GameObject> buytext;
    public List<GameObject> backpanel;

    //Shop
    public List<GameObject> buyButton1;
    public List<GameObject> putonButton1;
    public List<GameObject> goldimage1;
    public List<GameObject> buytext1;
    public List<GameObject> backpanel1;
    public List<Material> materials;

    private Puan puanScripti;
    public GameObject shop;
    public GameObject woodShop;

    public List<GameObject> playerNew;
    private GameObject previous_playerNew;

    private Renderer cy1;
    private Renderer cy2;
    private Renderer cy3;
    private Renderer cy4;
    private Renderer cy5;
    private Renderer cy6;
    private Renderer cy7;
    private Renderer cy8;
    private Renderer cy9;
    private Renderer cy10;
    private Renderer cy11;
    private Renderer cy12;
    private Renderer cy13;
    private Renderer cy14;
    private Renderer cy15;

    private int cylindernumber;
    private int playernumber;
    private Image c0, c1, c2, c3, c4, c5, c6, c7, c8;
    private Image s0, s1, s2, s3, s4, s5, s6, s7, s8;

    [SerializeField]
    private MeshRenderer finishedmesh;

    [SerializeField]
    private List<Animator> animshopPlayer;

    private int animsayac = 0, animsayac1 = 0, animsayac2 = 0, animsayac3 = 0, animsayac4 = 0, animsayac5 = 0,
        animsayac6 = 0, animsayac7 = 0, animsayac8 = 0;

    public bool oyundevam = false;
    public bool startgame = false;

    public float cameraspeed;

    private AudioSource cameram;

    public AudioClip nomany;
    public AudioClip yesmany;

    public Puan puanim;

    public GameObject touchfinger;

    private bool okego = false;

    private bool firsparticles0 = true;
    private bool firsparticles1 = true;
    private bool firsparticles2 = true;
    private bool firsparticles3 = true;
    private bool firsparticles4 = true;
    private bool firsparticles5 = true;
    private bool firsparticles6 = true;
    private bool firsparticles7 = true;
    private bool firsparticles8 = true;


    public int sayaci;

    public Vector3 a, b, c, d, e, f, g,h,i,j,k,l,m;
    public int pointsayac = 0;

    public Collider[] aa = new Collider[1];

    public LayerMask cyl_layer;


    public bool golevel = false;

    private GameObject levelnoenabled;

    public L3evelgenerator l3;
    public L4evelgenerator l4;
    public L5evelgenerator l5;
    public L6evelgenerator l6;
    public L7evelgenerator l7;
    public L8evelgenerator l8;
    public L9evelgenerator l9;
    public L10evelgenerator l10;
    public L11evelgenerator l11;
    public L12evelgenerator l12;
    public L13evelgenerator l13;
    public L14evelgenerator l14;
    public L15evelgenerator l15;
    public L16evelgenerator l16;
    public L17evelgenerator l17;
    public L18evelgenerator l18;
    public L19evelgenerator l19;
    public L20evelgenerator l20;
    public L21evelgenerator l21;
    public L22evelgenerator l22;
    public L23evelgenerator l23;
    public L24evelgenerator l24;
    public L25evelgenerator l25;
    public L26evelgenerator l26;
    public L27evelgenerator l27;
    public L28evelgenerator l28;
    public L29evelgenerator l29;
    public L30evelgenerator l30;
    public L31evelgenerator l31;
    public L32evelgenerator l32;
    public L33evelgenerator l33;
    public L34evelgenerator l34;
    public L35evelgenerator l35;
    public L36evelgenerator l36;
    public L37evelgenerator l37;
    public L38evelgenerator l38;
    public L39evelgenerator l39;
    public L40evelgenerator l40;
    public L41evelgenerator l41;
    public L42evelgenerator l42;
    public L43evelgenerator l43;
    public L44evelgenerator l44;
    public L45evelgenerator l45;
    public L46evelgenerator l46;
    public L47evelgenerator l47;
    public L48evelgenerator l48;
    public L49evelgenerator l49;
    public L50evelgenerator l50;
    public L51evelgenerator l51;

    public GameObject cloud1, cloud2, cloud3;

    public GameObject sahnecloud1, sahnecloud2, sahnecloud3, sahnecloud4;

    public Sprite spritecloud1, spritecloud2, spritecloud3;

    public int randomcloud;

    public Camera camcloud;

    public int interstitial = 0;

    public Text kontrol;
    public GameObject panel;

    public int net = 0;
    private void Awake()
    {

        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            net = 1;
        }
        else if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork || Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
            net = 2;
        }

        Input.simulateMouseWithTouches = false;
        Screen.SetResolution(Screen.currentResolution.width / 1, Screen.currentResolution.height / 1, true);

        camcloud = Camera.main.GetComponent<Camera>();
        gm = this;
        randomcloud = PlayerPrefs.GetInt("clouds25",0);
        if (randomcloud == 0)
        {
            camcloud.backgroundColor = new Color32(86, 177, 231, 0);
            sahnecloud1.GetComponent<SpriteRenderer>().sprite = spritecloud1;
            sahnecloud2.GetComponent<SpriteRenderer>().sprite = spritecloud1;
            sahnecloud3.GetComponent<SpriteRenderer>().sprite = spritecloud1;
            sahnecloud4.GetComponent<SpriteRenderer>().sprite = spritecloud1;
        }
        else if (randomcloud == 1)
        {
            camcloud.backgroundColor = new Color32(86, 125, 231, 0);
            sahnecloud1.GetComponent<SpriteRenderer>().sprite = spritecloud2;
            sahnecloud2.GetComponent<SpriteRenderer>().sprite = spritecloud2;
            sahnecloud3.GetComponent<SpriteRenderer>().sprite = spritecloud2;
            sahnecloud4.GetComponent<SpriteRenderer>().sprite = spritecloud2;
        }
        else if (randomcloud == 2)
        {
            camcloud.backgroundColor = new Color32(241, 217, 128, 0);
            sahnecloud1.GetComponent<SpriteRenderer>().sprite = spritecloud3;
            sahnecloud2.GetComponent<SpriteRenderer>().sprite = spritecloud3;
            sahnecloud3.GetComponent<SpriteRenderer>().sprite = spritecloud3;
            sahnecloud4.GetComponent<SpriteRenderer>().sprite = spritecloud3;
        }
        a = new Vector3();
        b = new Vector3();
        c = new Vector3();
        d = new Vector3();
        e = new Vector3();
        f = new Vector3();
        g = new Vector3();
        h = new Vector3();
        i = new Vector3();
        j = new Vector3();
        k = new Vector3();
        l = new Vector3();
        m = new Vector3();

        puanim = GameObject.FindGameObjectWithTag("puan").GetComponent<Puan>();
        cameram = Camera.main.GetComponent<AudioSource>();
        c0 = backpanel1[0].GetComponent<Image>();
        c1 = backpanel1[1].GetComponent<Image>();
        c2 = backpanel1[2].GetComponent<Image>();
        c3 = backpanel1[3].GetComponent<Image>();
        c4 = backpanel1[4].GetComponent<Image>();
        c5 = backpanel1[5].GetComponent<Image>();
        c6 = backpanel1[6].GetComponent<Image>();
        c7 = backpanel1[7].GetComponent<Image>();
        c8 = backpanel1[8].GetComponent<Image>();

        s0 = backpanel[0].GetComponent<Image>();
        s1 = backpanel[1].GetComponent<Image>();
        s2 = backpanel[2].GetComponent<Image>();
        s3 = backpanel[3].GetComponent<Image>();
        s4 = backpanel[4].GetComponent<Image>();
        s5 = backpanel[5].GetComponent<Image>();
        s6 = backpanel[6].GetComponent<Image>();
        s7 = backpanel[7].GetComponent<Image>();
        s8 = backpanel[8].GetComponent<Image>();

        particlerenderer = particleWood.GetComponent<Renderer>();
        branchrenderer = branch.GetComponent<Renderer>();
        cylrenderer = cylinder.GetComponent<Renderer>();
        currentlevel = PlayerPrefs.GetInt("levelgo35",1);
        curumlevel = PlayerPrefs.GetInt("curum5", 1);
        puanScripti = GameObject.FindObjectOfType<Puan>().GetComponent<Puan>();
        konum = GameObject.Find("konum");
        taptofirslevel_text.text = curumlevel + "";
        taptosecondlevel_text.text = curumlevel + 1 + "";

        if (PlayerPrefs.GetInt("buy1") == 1)
        {
            buyButton[0].SetActive(false);
            goldimage[0].SetActive(false);
            buytext[0].SetActive(false);
            putonButton[1].SetActive(true);
        }
        if (PlayerPrefs.GetInt("buy2") == 1)
        {
            buyButton[1].SetActive(false);
            goldimage[1].SetActive(false);
            buytext[1].SetActive(false);
            putonButton[2].SetActive(true);
        }
        if (PlayerPrefs.GetInt("buy3") == 1)
        {
            buyButton[2].SetActive(false);
            goldimage[2].SetActive(false);
            buytext[2].SetActive(false);
            putonButton[3].SetActive(true);
        }
        if (PlayerPrefs.GetInt("buy4") == 1)
        {
            buyButton[3].SetActive(false);
            goldimage[3].SetActive(false);
            buytext[3].SetActive(false);
            putonButton[4].SetActive(true);
        }
        if (PlayerPrefs.GetInt("buy5") == 1)
        {
            buyButton[4].SetActive(false);
            goldimage[4].SetActive(false);
            buytext[4].SetActive(false);
            putonButton[5].SetActive(true);
        }
        if (PlayerPrefs.GetInt("buy6") == 1)
        {
            buyButton[5].SetActive(false);
            goldimage[5].SetActive(false);
            buytext[5].SetActive(false);
            putonButton[6].SetActive(true);
        }
        if (PlayerPrefs.GetInt("buy7") == 1)
        {
            buyButton[6].SetActive(false);
            goldimage[6].SetActive(false);
            buytext[6].SetActive(false);
            putonButton[7].SetActive(true);
        }
        if (PlayerPrefs.GetInt("buy8") == 1)
        {
            buyButton[7].SetActive(false);
            goldimage[7].SetActive(false);
            buytext[7].SetActive(false);
            putonButton[8].SetActive(true);
        }
        if (PlayerPrefs.GetInt("buyc1") == 1)
        {
            buyButton1[0].SetActive(false);
            goldimage1[0].SetActive(false);
            buytext1[0].SetActive(false);
            putonButton1[1].SetActive(true);
        }
        if (PlayerPrefs.GetInt("buyc2") == 1)
        {
            buyButton1[1].SetActive(false);
            goldimage1[1].SetActive(false);
            buytext1[1].SetActive(false);
            putonButton1[2].SetActive(true);
        }
        if (PlayerPrefs.GetInt("buyc3") == 1)
        {
            buyButton1[2].SetActive(false);
            goldimage1[2].SetActive(false);
            buytext1[2].SetActive(false);
            putonButton1[3].SetActive(true);
        }
        if (PlayerPrefs.GetInt("buyc4") == 1)
        {
            buyButton1[3].SetActive(false);
            goldimage1[3].SetActive(false);
            buytext1[3].SetActive(false);
            putonButton1[4].SetActive(true);
        }
        if (PlayerPrefs.GetInt("buyc5") == 1)
        {
            buyButton1[4].SetActive(false);
            goldimage1[4].SetActive(false);
            buytext1[4].SetActive(false);
            putonButton1[5].SetActive(true);
        }
        if (PlayerPrefs.GetInt("buyc6") == 1)
        {
            buyButton1[5].SetActive(false);
            goldimage1[5].SetActive(false);
            buytext1[5].SetActive(false);
            putonButton1[6].SetActive(true);
        }
        if (PlayerPrefs.GetInt("buyc7") == 1)
        {
            buyButton1[6].SetActive(false);
            goldimage1[6].SetActive(false);
            buytext1[6].SetActive(false);
            putonButton1[7].SetActive(true);
        }
        if (PlayerPrefs.GetInt("buyc8") == 1)
        {
            buyButton1[7].SetActive(false);
            goldimage1[7].SetActive(false);
            buytext1[7].SetActive(false);
            putonButton1[8].SetActive(true);
        }

        playernumber = PlayerPrefs.GetInt("getPlayers",0);
        switch (playernumber)
        {
            case 0:
                putOn1();
                break;
            case 1:
                putOn2();
                break;
            case 2:
                putOn9();
                break;
            case 3:
                putOn4();
                break;
            case 4:
                putOn5();
                break;
            case 5:
                putOn6();
                break;
            case 6:
                putOn7();
                break;
            case 7:
                putOn8();
                break;
            case 8:
                putOn3();
                break;
            default:
                break;
        }
        cylindernumber = PlayerPrefs.GetInt("getCylinders",0);
        switch (cylindernumber)
        {
            case 0:
                WoodputOn1();
                break;
            case 1:
                WoodputOn2();
                break;
            case 2:
                WoodputOn3();
                break;
            case 3:
                WoodputOn4();
                break;
            case 4:
                WoodputOn5();
                break;
            case 5:
                WoodputOn6();
                break;
            case 6:
                WoodputOn7();
                break;
            case 7:
                WoodputOn8();
                break;
            case 8:
                WoodputOn9();
                break;
            default:
                break;
        }
    }

    
    void Update()
    {
        if (okego)
        {
            if (Application.internetReachability == NetworkReachability.NotReachable)
            {
                panel.SetActive(true);
            }
            else if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork || Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
            {
                panel.SetActive(false);
                if (Input.touchCount > 0)
                {
                    Touch touch = Input.GetTouch(0);
                    if (touch.phase == TouchPhase.Began)
                    {
                        startgame = true;
                        oyundevam = true;
                        if (touchfinger != null)
                        {
                            touchfinger.SetActive(false);
                        }
                        okego = false;
                    }
                }
            }
        }

        if (startgame && oyundevam)
        {
            cc.speed += cameraspeed / 10000 * difficulty;
            //Time.timeSinceLevelLoad;
            cc.speed = Mathf.Clamp(cc.speed, 1, 15);
        }


        if (konum != null)
        {
            float distance = Vector3.Distance(konum.transform.position, playerStartPoint.position);
            waydistance = distance;
            //print(LevelGenerator.lv.andgamedistance);
            #region currentlevelandgamedistance
            if (currentlevel == 1)
            {
                float x = waydistance / (LevelGenerator.lv.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 2)
            {
                float x = waydistance / (LLevelGenerator.llv.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 3)
            {
                float x = waydistance / (l3.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 4)
            {
                float x = waydistance / (l4.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 5)
            {
                float x = waydistance / (l5.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 6)
            {
                float x = waydistance / (l6.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 7)
            {
                float x = waydistance / (l7.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 8)
            {
                float x = waydistance / (l8.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 9)
            {
                float x = waydistance / (l9.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 10)
            {
                float x = waydistance / (l10.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 11)
            {
                float x = waydistance / (l11.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 12)
            {
                float x = waydistance / (l12.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 13)
            {
                float x = waydistance / (l13.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 14)
            {
                float x = waydistance / (l14.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 15)
            {
                float x = waydistance / (l15.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 16)
            {
                float x = waydistance / (l16.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 17)
            {
                float x = waydistance / (l17.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 18)
            {
                float x = waydistance / (l18.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 19)
            {
                float x = waydistance / (l19.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 20)
            {
                float x = waydistance / (l20.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 21)
            {
                float x = waydistance / (l21.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 22)
            {
                float x = waydistance / (l22.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 23)
            {
                float x = waydistance / (l23.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 24)
            {
                float x = waydistance / (l24.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 25)
            {
                float x = waydistance / (l25.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 26)
            {
                float x = waydistance / (l26.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 27)
            {
                float x = waydistance / (l27.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 28)
            {
                float x = waydistance / (l28.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 29)
            {
                float x = waydistance / (l29.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 30)
            {
                float x = waydistance / (l30.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 31)
            {
                float x = waydistance / (l31.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 32)
            {
                float x = waydistance / (l32.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 33)
            {
                float x = waydistance / (l33.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 34)
            {
                float x = waydistance / (l34.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 35)
            {
                float x = waydistance / (l35.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 36)
            {
                float x = waydistance / (l36.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 37)
            {
                float x = waydistance / (l37.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 38)
            {
                float x = waydistance / (l38.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 39)
            {
                float x = waydistance / (l39.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 40)
            {
                float x = waydistance / (l40.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 41)
            {
                float x = waydistance / (l41.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 42)
            {
                float x = waydistance / (l42.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 43)
            {
                float x = waydistance / (l43.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 44)
            {
                float x = waydistance / (l44.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 45)
            {
                float x = waydistance / (l45.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 46)
            {
                float x = waydistance / (l46.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 47)
            {
                float x = waydistance / (l47.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 48)
            {
                float x = waydistance / (l48.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 49)
            {
                float x = waydistance / (l49.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 50)
            {
                float x = waydistance / (l50.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
            else if (currentlevel == 51)
            {
                float x = waydistance / (l51.andgamedistance - 5);
                distanceimage.fillAmount = x;
                distanceimage.color = Color.Lerp(Color.black, Color.blue, x);
            }
#endregion

            //print(distance);
        }

    }

    public void golevelbtn()
    {
        #region currentlevel
        if (GameManager.gm.currentlevel == 1)
        {
            if (!gameObject.CompareTag("Enemy") && LevelGenerator.lv.odunsayisi >= 2 && LevelGenerator.lv.odunsayisi <= LevelGenerator.lv.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 2)
        {
            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.llg.odunsayisi >= 2 && headForLevelGeneration.hflg.llg.odunsayisi <= headForLevelGeneration.hflg.llg.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }

        }
        else if (GameManager.gm.currentlevel == 3)
        {
            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l3.odunsayisi >= 2 && headForLevelGeneration.hflg.l3.odunsayisi <= headForLevelGeneration.hflg.l3.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 4)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l4.odunsayisi >= 2 && headForLevelGeneration.hflg.l4.odunsayisi <= headForLevelGeneration.hflg.l4.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 5)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l5.odunsayisi >= 2 && headForLevelGeneration.hflg.l5.odunsayisi <= headForLevelGeneration.hflg.l5.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 6)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l6.odunsayisi >= 2 && headForLevelGeneration.hflg.l6.odunsayisi <= headForLevelGeneration.hflg.l6.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 7)
        {
            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l7.odunsayisi >= 2 && headForLevelGeneration.hflg.l7.odunsayisi <= headForLevelGeneration.hflg.l7.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 8)
        {
            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l8.odunsayisi >= 2 && headForLevelGeneration.hflg.l8.odunsayisi <= headForLevelGeneration.hflg.l8.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 9)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l9.odunsayisi >= 2 && headForLevelGeneration.hflg.l9.odunsayisi <= headForLevelGeneration.hflg.l9.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 10)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l10.odunsayisi >= 2 && headForLevelGeneration.hflg.l10.odunsayisi <= headForLevelGeneration.hflg.l10.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 11)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l11.odunsayisi >= 2 && headForLevelGeneration.hflg.l11.odunsayisi <= headForLevelGeneration.hflg.l11.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 12)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l12.odunsayisi >= 2 && headForLevelGeneration.hflg.l12.odunsayisi <= headForLevelGeneration.hflg.l12.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 13)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l13.odunsayisi >= 2 && headForLevelGeneration.hflg.l13.odunsayisi <= headForLevelGeneration.hflg.l13.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 14)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l14.odunsayisi >= 2 && headForLevelGeneration.hflg.l14.odunsayisi <= headForLevelGeneration.hflg.l14.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 15)
        {
            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l15.odunsayisi >= 2 && headForLevelGeneration.hflg.l15.odunsayisi <= headForLevelGeneration.hflg.l15.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 16)
        {
            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l16.odunsayisi >= 2 && headForLevelGeneration.hflg.l16.odunsayisi <= headForLevelGeneration.hflg.l16.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 17)
        {
            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l17.odunsayisi >= 2 && headForLevelGeneration.hflg.l17.odunsayisi <= headForLevelGeneration.hflg.l17.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 18)
        {
            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l18.odunsayisi >= 2 && headForLevelGeneration.hflg.l18.odunsayisi <= headForLevelGeneration.hflg.l18.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 19)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l19.odunsayisi >= 2 && headForLevelGeneration.hflg.l19.odunsayisi <= headForLevelGeneration.hflg.l19.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 20)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l20.odunsayisi >= 2 && headForLevelGeneration.hflg.l20.odunsayisi <= headForLevelGeneration.hflg.l20.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 21)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l21.odunsayisi >= 2 && headForLevelGeneration.hflg.l21.odunsayisi <= headForLevelGeneration.hflg.l21.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 22)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l22.odunsayisi >= 2 && headForLevelGeneration.hflg.l22.odunsayisi <= headForLevelGeneration.hflg.l22.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 23)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l23.odunsayisi >= 2 && headForLevelGeneration.hflg.l23.odunsayisi <= headForLevelGeneration.hflg.l23.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 24)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l24.odunsayisi >= 2 && headForLevelGeneration.hflg.l24.odunsayisi <= headForLevelGeneration.hflg.l24.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 25)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l25.odunsayisi >= 2 && headForLevelGeneration.hflg.l25.odunsayisi <= headForLevelGeneration.hflg.l25.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 26)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l26.odunsayisi >= 2 && headForLevelGeneration.hflg.l26.odunsayisi <= headForLevelGeneration.hflg.l26.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 27)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l27.odunsayisi >= 2 && headForLevelGeneration.hflg.l27.odunsayisi <= headForLevelGeneration.hflg.l27.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 28)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l28.odunsayisi >= 2 && headForLevelGeneration.hflg.l28.odunsayisi <= headForLevelGeneration.hflg.l28.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 29)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l29.odunsayisi >= 2 && headForLevelGeneration.hflg.l29.odunsayisi <= headForLevelGeneration.hflg.l29.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 30)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l30.odunsayisi >= 2 && headForLevelGeneration.hflg.l30.odunsayisi <= headForLevelGeneration.hflg.l30.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 31)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l31.odunsayisi >= 2 && headForLevelGeneration.hflg.l31.odunsayisi <= headForLevelGeneration.hflg.l31.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 32)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l32.odunsayisi >= 2 && headForLevelGeneration.hflg.l32.odunsayisi <= headForLevelGeneration.hflg.l32.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 33)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l33.odunsayisi >= 2 && headForLevelGeneration.hflg.l33.odunsayisi <= headForLevelGeneration.hflg.l33.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 34)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l34.odunsayisi >= 2 && headForLevelGeneration.hflg.l34.odunsayisi <= headForLevelGeneration.hflg.l34.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 35)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l35.odunsayisi >= 2 && headForLevelGeneration.hflg.l35.odunsayisi <= headForLevelGeneration.hflg.l35.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 36)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l36.odunsayisi >= 2 && headForLevelGeneration.hflg.l36.odunsayisi <= headForLevelGeneration.hflg.l36.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 37)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l37.odunsayisi >= 2 && headForLevelGeneration.hflg.l37.odunsayisi <= headForLevelGeneration.hflg.l37.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 38)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l38.odunsayisi >= 2 && headForLevelGeneration.hflg.l38.odunsayisi <= headForLevelGeneration.hflg.l38.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 39)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l39.odunsayisi >= 2 && headForLevelGeneration.hflg.l39.odunsayisi <= headForLevelGeneration.hflg.l39.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 40)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l40.odunsayisi >= 2 && headForLevelGeneration.hflg.l40.odunsayisi <= headForLevelGeneration.hflg.l40.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 41)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l41.odunsayisi >= 2 && headForLevelGeneration.hflg.l41.odunsayisi <= headForLevelGeneration.hflg.l41.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 42)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l42.odunsayisi >= 2 && headForLevelGeneration.hflg.l42.odunsayisi <= headForLevelGeneration.hflg.l42.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 43)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l43.odunsayisi >= 2 && headForLevelGeneration.hflg.l43.odunsayisi <= headForLevelGeneration.hflg.l43.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 44)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l44.odunsayisi >= 2 && headForLevelGeneration.hflg.l44.odunsayisi <= headForLevelGeneration.hflg.l44.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 45)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l45.odunsayisi >= 2 && headForLevelGeneration.hflg.l45.odunsayisi <= headForLevelGeneration.hflg.l45.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 46)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l46.odunsayisi >= 2 && headForLevelGeneration.hflg.l46.odunsayisi <= headForLevelGeneration.hflg.l46.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 47)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l47.odunsayisi >= 2 && headForLevelGeneration.hflg.l47.odunsayisi <= headForLevelGeneration.hflg.l47.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 48)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l48.odunsayisi >= 2 && headForLevelGeneration.hflg.l48.odunsayisi <= headForLevelGeneration.hflg.l48.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 49)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l49.odunsayisi >= 2 && headForLevelGeneration.hflg.l49.odunsayisi <= headForLevelGeneration.hflg.l49.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 50)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l50.odunsayisi >= 2 && headForLevelGeneration.hflg.l50.odunsayisi <= headForLevelGeneration.hflg.l50.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        else if (GameManager.gm.currentlevel == 51)
        {

            if (!SpawnPoint.sppo.gameObject.CompareTag("Enemy") && headForLevelGeneration.hflg.l51.odunsayisi >= 2 && headForLevelGeneration.hflg.l51.odunsayisi <= headForLevelGeneration.hflg.l51.windowtreenumber)
            {
                SpawnPoint.sppo.CreatePoints();
                SpawnPoint.sppo.CreateBranch();
            }
        }
        #endregion



        pointsayac = 0;
        randomcloud = Random.Range(0, 3);
        PlayerPrefs.SetInt("clouds25", randomcloud);
        if (randomcloud == 0)
        {
            CloudGeneratorScript.cgs.clouds = cloud1;
            camcloud.backgroundColor = new Color32(86, 177, 231, 0);
            for (int i = 0; i < CloudGeneratorScript.cgs.cloudnumber+ 4; i++)
            {
                GameObject.FindGameObjectsWithTag("sahnecloud")[i].GetComponent<SpriteRenderer>().sprite = spritecloud1;
            }
        }
        else if (randomcloud == 1)
        {
            CloudGeneratorScript.cgs.clouds = cloud2;
            camcloud.backgroundColor = new Color32(86, 125, 231, 0);
            for (int i = 0; i < CloudGeneratorScript.cgs.cloudnumber + 4; i++)
            {
                GameObject.FindGameObjectsWithTag("sahnecloud")[i].GetComponent<SpriteRenderer>().sprite = spritecloud2;
            }
        }
        else if (randomcloud == 2)
        {
            CloudGeneratorScript.cgs.clouds = cloud3;
            camcloud.backgroundColor = new Color32(241, 217, 128, 0);
            for (int i = 0; i < CloudGeneratorScript.cgs.cloudnumber + 4; i++)
            {
                GameObject.FindGameObjectsWithTag("sahnecloud")[i].GetComponent<SpriteRenderer>().sprite = spritecloud3;
            }
        }

        
        levelnoenabled = GameObject.FindGameObjectWithTag("level" + currentlevel);
        levelnoenabled.SetActive(false);
        currentlevel += 1;
        curumlevel += 1;
        if (curumlevel == 52)
        {
            currentlevel = 1;
            PlayerPrefs.SetInt("levelgo35", currentlevel);
            PlayerPrefs.SetInt("curum5", curumlevel);
            SceneManager.LoadScene(1);
        }
        else if (curumlevel == 104)
        {
            currentlevel = 1;
            PlayerPrefs.SetInt("levelgo35", currentlevel);
            PlayerPrefs.SetInt("curum5", curumlevel);
            SceneManager.LoadScene(2);
        }
        else if (curumlevel == 156)
        {
            currentlevel = 1;
            PlayerPrefs.SetInt("levelgo35", currentlevel);
            PlayerPrefs.SetInt("curum5", curumlevel);
            SceneManager.LoadScene(3);
        }
        else if (curumlevel == 208)
        {
            currentlevel = 1;
            PlayerPrefs.SetInt("levelgo35", currentlevel);
            PlayerPrefs.SetInt("curum5", curumlevel);
            SceneManager.LoadScene(4);
        }
        else if (curumlevel == 260)
        {
            currentlevel = 1;
            PlayerPrefs.SetInt("levelgo35", currentlevel);
            PlayerPrefs.SetInt("curum5", curumlevel);
            SceneManager.LoadScene(5);
        }

        PlayerPrefs.SetInt("levelgo35", currentlevel);
        PlayerPrefs.SetInt("curum5", curumlevel);
        //golevel = true;
        Camera.main.transform.position = new Vector3(0f, 12.03f, -7f);
        int playernumber = PlayerPrefs.GetInt("getPlayers", 0);
        switch (playernumber)
        {
            case 0:
                //previous_playerNew = Instantiate(playerNew[0], Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f), Quaternion.Euler(90f, 0f, -90f));
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
                //previous_playerNew.transform.parent = Camera.main.transform;
                break;
            case 1:
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(0.3f, 0.1f, 0.3f);
                break;
            case 2:
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(3f, 1.5f, 3f);
                break;
            case 3:
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(0.168f, 0.04f, 0.168f);
                break;
            case 4:
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0.4f);
                break;
            case 5:
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(2.5f, 2.5f, 1f);
                break;
            case 6:
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(2.5f, 2.5f, 2f);
                break;
            case 7:
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(0.2f, 0.06f, 0.2f);
                break;
            case 8:
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.2f);
                break;
            default:
                break;
        }


        UIManager.ui_m.Closelevelcompleted();
        UIManager.ui_m.OpenTapToPlay();

        UIManager.ui_m.firslevel_text.text = curumlevel + "";
        UIManager.ui_m.secondlevel_text.text = (curumlevel + 1) + "";
        taptofirslevel_text.text = curumlevel + "";
        taptosecondlevel_text.text = curumlevel + 1 + "";
        //SceneManager.LoadScene(currentlevel);
        Admob.adm.truemi2 = true;
        Admob.adm.truemi3 = true;
        if (Admob.adm.reward2)
        {
            Admob.adm.RequestRewarded1();
        }
        if (Admob.adm.reward3)
        {
            Admob.adm.RequestRewarded2();
        }
        if (interstitial == 3)
        {
            Admob.adm.OpenInterstitial();
        }
    }

    public void TouchToRestart()
    {
        SpawnPoint.sppo.restartCreatePoints();
        pointsayac = 0;

        PlayerManager.pm.particlenumber = PlayerPrefs.GetInt("getCylinders");
        PlayerManager.pm.playernumber = PlayerPrefs.GetInt("getPlayers");
        PlayerManager.pm.cylindernumber = PlayerPrefs.GetInt("getCylinders");

        cc.transform.position = new Vector3(0, 12.03f, -7);
        UIManager.ui_m.CloseGameOverUI();
        UIManager.ui_m.OpenTapToPlay();
        cc.speed = 4.5f;
        UIManager.ui_m.SetPlayerHealth(10f);
        PlayerManager.pm.health = 10.0f;


        int playernumber = PlayerPrefs.GetInt("getPlayers", 0);
        switch (playernumber)
        {
            case 0:
                //previous_playerNew = Instantiate(playerNew[0], Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f), Quaternion.Euler(90f, 0f, -90f));
                PlayerManager.pm.gameObject.transform.position = Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f);
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
                //previous_playerNew.transform.parent = Camera.main.transform;
                break;
            case 1:
                PlayerManager.pm.gameObject.transform.position = Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f);
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(0.3f, 0.1f, 0.3f);
                break;
            case 2:
                PlayerManager.pm.gameObject.transform.position = Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f);
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(3f, 1.5f, 3f);
                break;
            case 3:
                PlayerManager.pm.gameObject.transform.position = Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f);
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(0.168f, 0.04f, 0.168f);
                break;
            case 4:
                PlayerManager.pm.gameObject.transform.position = Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f);
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0.4f);
                break;
            case 5:
                PlayerManager.pm.gameObject.transform.position = Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f);
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(2.5f, 2.5f, 1f);
                break;
            case 6:
                PlayerManager.pm.gameObject.transform.position = Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f);
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(2.5f, 2.5f, 2f);
                break;
            case 7:
                PlayerManager.pm.gameObject.transform.position = Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f);
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(0.2f, 0.06f, 0.2f);
                break;
            case 8:
                PlayerManager.pm.gameObject.transform.position = Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f);
                PlayerManager.pm.gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.2f);
                break;
            default:
                break;
        }

        //SceneManager.LoadScene(currentlevel);
        Admob.adm.truemi2 = true;
        Admob.adm.truemi3 = true;
        if (Admob.adm.reward2)
        {
            Admob.adm.RequestRewarded1();
        }
        if (Admob.adm.reward3)
        {
            Admob.adm.RequestRewarded2();

        }
        if (interstitial == 3)
        {
            Admob.adm.OpenInterstitial();
        }
    }

    public void TapToPlay()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            panel.SetActive(true);
        }
        else if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork || Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
            if (net == 1)
            {
                if (Admob.adm.reklamokemi == 0)
                {
                    Admob.adm.InitializePurchasing();
                    MobileAds.Initialize(initStatus => { });

                    Admob.adm.RequestBanner();
                    //RequestInterstitial();
                    Admob.adm.RequestRewarded();
                    Admob.adm.RequestRewarded1();
                    Admob.adm.RequestRewarded2();
                }
            }
            net = 2;
            panel.SetActive(false);
            //Load Scene when we click
            UIManager.ui_m.CloseTapToPlay();
            UIManager.ui_m.OpenGamePanel();
            cc.speed = 4.5f;
            UIManager.ui_m.SetPlayerHealth(10f);
            PlayerManager.pm.health = 10.0f;

            sayaci = 3;

            if (touchfinger != null)
            {
                touchfinger.SetActive(true);
            }

            okego = true;


            cylindernumber = PlayerPrefs.GetInt("getCylinders", 0);
            switch (cylindernumber)
            {

                case 0:
                    if (firsparticles0)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[6]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                        firsparticles0 = false;
                    }
                    else if (firsparticles1 == false || firsparticles2 == false || firsparticles3 == false || firsparticles4 == false
                        || firsparticles5 == false || firsparticles6 == false || firsparticles7 == false || firsparticles8 == false)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[6]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                    }
                    break;
                case 1:
                    if (firsparticles1)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[8]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                        firsparticles1 = false;
                    }
                    else if (firsparticles0 == false || firsparticles2 == false || firsparticles3 == false || firsparticles4 == false
        || firsparticles5 == false || firsparticles6 == false || firsparticles7 == false || firsparticles8 == false)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[8]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                    }
                    break;
                case 2:
                    if (firsparticles2)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[2]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                        firsparticles2 = false;
                    }
                    else if (firsparticles1 == false || firsparticles0 == false || firsparticles3 == false || firsparticles4 == false
        || firsparticles5 == false || firsparticles6 == false || firsparticles7 == false || firsparticles8 == false)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[2]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                    }
                    break;
                case 3:
                    if (firsparticles3)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[3]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                        firsparticles3 = false;
                    }
                    else if (firsparticles1 == false || firsparticles2 == false || firsparticles0 == false || firsparticles4 == false
        || firsparticles5 == false || firsparticles6 == false || firsparticles7 == false || firsparticles8 == false)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[3]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                    }
                    break;
                case 4:
                    if (firsparticles4)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[4]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                        firsparticles4 = false;
                    }
                    else if (firsparticles1 == false || firsparticles2 == false || firsparticles3 == false || firsparticles0 == false
        || firsparticles5 == false || firsparticles6 == false || firsparticles7 == false || firsparticles8 == false)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[4]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                    }
                    break;
                case 5:
                    if (firsparticles5)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[5]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                        firsparticles5 = false;
                    }
                    else if (firsparticles1 == false || firsparticles2 == false || firsparticles3 == false || firsparticles4 == false
        || firsparticles0 == false || firsparticles6 == false || firsparticles7 == false || firsparticles8 == false)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[5]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                    }
                    break;
                case 6:
                    if (firsparticles6)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[0]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                        firsparticles6 = false;
                    }
                    else if (firsparticles1 == false || firsparticles2 == false || firsparticles3 == false || firsparticles4 == false
        || firsparticles5 == false || firsparticles0 == false || firsparticles7 == false || firsparticles8 == false)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[0]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                    }
                    break;
                case 7:
                    if (firsparticles7)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[7]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                        firsparticles7 = false;
                    }
                    else if (firsparticles1 == false || firsparticles2 == false || firsparticles3 == false || firsparticles4 == false
        || firsparticles5 == false || firsparticles6 == false || firsparticles0 == false || firsparticles8 == false)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[7]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                    }
                    break;
                case 8:
                    if (firsparticles8)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[1]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                        firsparticles8 = false;
                    }
                    else if (firsparticles1 == false || firsparticles2 == false || firsparticles3 == false || firsparticles4 == false
        || firsparticles5 == false || firsparticles6 == false || firsparticles7 == false || firsparticles0 == false)
                    {
                        GoldNumber.goldn.havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[1]);
                        GoldNumber.goldn.havuz.HavuzuDoldur(55);
                    }
                    break;
                default:
                    break;
            }
            //havuz2 = new ObjeHavuzu(prefab2);
            //havuz2.HavuzuDoldur(100);



            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //SceneManager.LoadScene("Level2");
            interstitial++;
            if (interstitial == 3)
            {
                Admob.adm.RequestInterstitial();
            }
            Admob.adm.truemi1 = true;
            if (Admob.adm.reward1)
            {
                Admob.adm.RequestRewarded();
            }
        }
    }

    public void woodOpen()
    {
        bug = true;
        ShopController.sc.canvasCamera1Open();
        ShopController.sc.canvasSettings2();
        startwood1 = true;
        woodShop.SetActive(true);
    }
    public void woodClose()
    {
      
        bug = false;
        woodShop.SetActive(false);
        ShopController.sc.canvasSettings1();
        startwood1 = false;
        ShopController.sc.canvasCamera1Close();
    }

    public void shopOpen()
    {
        ShopController.sc.canvasCameraOpen();
        ShopController.sc.canvasSettings2();
        shop.SetActive(true);
        animsayac = 0;
        animsayac1 = 0;
        animsayac2 = 0;
        animsayac3 = 0;
        animsayac4 = 0;
        animsayac5 = 0;
        animsayac6 = 0;
        animsayac7 = 0;
        animsayac8 = 0;
    }

    public void shopClose()
    {
        ShopController.sc.canvasCameraClose();
        ShopController.sc.canvasSettings1();
        shop.SetActive(false);
    }

    public void buyRing1()
    {
        if (puanim.puan >= 50)
        {
            PlayerPrefs.SetInt("buy1", 1);
            buyButton[0].SetActive(false);
            goldimage[0].SetActive(false);
            buytext[0].SetActive(false);
            puanim.puan -= 50;
            puanScripti.satinAl();
            putonButton[1].SetActive(true);
            cameram.PlayOneShot(yesmany, 1f);
        }
        else
        {
            cameram.PlayOneShot(nomany,1f);
        }

    }
    public void buyRing2()
    {
        if (puanim.puan >= 100)
        {
            PlayerPrefs.SetInt("buy2", 1);
            buyButton[1].SetActive(false);
            goldimage[1].SetActive(false);
            buytext[1].SetActive(false);
            puanim.puan -= 100;
            puanScripti.satinAl();
            putonButton[2].SetActive(true);
            cameram.PlayOneShot(yesmany, 1f);
        }
        else
        {
            cameram.PlayOneShot(nomany, 1f);
        }
    }
    public void buyRing3()
    {
        if (puanim.puan >= 175)
        {
            PlayerPrefs.SetInt("buy3", 1);
            buyButton[2].SetActive(false);
            goldimage[2].SetActive(false);
            buytext[2].SetActive(false);
            puanim.puan -= 175;
            puanScripti.satinAl();
            putonButton[3].SetActive(true);
            cameram.PlayOneShot(yesmany, 1f);
        }
        else
        {
            cameram.PlayOneShot(nomany, 1f);
        }
    }
    public void buyRing4()
    {
        if (puanim.puan >= 250)
        {
            PlayerPrefs.SetInt("buy4", 1);
            buyButton[3].SetActive(false);
            goldimage[3].SetActive(false);
            buytext[3].SetActive(false);
            puanim.puan -= 250;
            puanScripti.satinAl();
            putonButton[4].SetActive(true);
            cameram.PlayOneShot(yesmany, 1f);
        }
        else
        {
            cameram.PlayOneShot(nomany, 1f);
        }
    }
    public void buyRing5()
    {
        if (puanim.puan >= 350)
        {
            PlayerPrefs.SetInt("buy5", 1);
            buyButton[4].SetActive(false);
            goldimage[4].SetActive(false);
            buytext[4].SetActive(false);
            puanim.puan -= 350;
            puanScripti.satinAl();
            putonButton[5].SetActive(true);
            cameram.PlayOneShot(yesmany, 1f);
        }
        else
        {
            cameram.PlayOneShot(nomany, 1f);
        }
    }
    public void buyRing6()
    {
        if (puanim.puan >= 500)
        {
            PlayerPrefs.SetInt("buy6", 1);
            buyButton[5].SetActive(false);
            goldimage[5].SetActive(false);
            buytext[5].SetActive(false);
            puanim.puan -= 500;
            puanScripti.satinAl();
            putonButton[6].SetActive(true);
            cameram.PlayOneShot(yesmany, 1f);
        }
        else
        {
            cameram.PlayOneShot(nomany, 1f);
        }
    }
    public void buyRing7()
    {
        if (puanim.puan >= 750)
        {
            PlayerPrefs.SetInt("buy7", 1);
            buyButton[6].SetActive(false);
            goldimage[6].SetActive(false);
            buytext[6].SetActive(false);
            puanim.puan -= 750;
            puanScripti.satinAl();
            putonButton[7].SetActive(true);
            cameram.PlayOneShot(yesmany, 1f);
        }
        else
        {
            cameram.PlayOneShot(nomany, 1f);
        }
    }
    public void buyRing8()
    {
        if (puanim.puan >= 1000)
        {
            PlayerPrefs.SetInt("buy8", 1);
            buyButton[7].SetActive(false);
            goldimage[7].SetActive(false);
            buytext[7].SetActive(false);
            puanim.puan -= 1000;
            puanScripti.satinAl();
            putonButton[8].SetActive(true);
            cameram.PlayOneShot(yesmany, 1f);
        }
        else
        {
            cameram.PlayOneShot(nomany, 1f);
        }
    }

    private void ringcontrol0()
    {
        putonButton[0].SetActive(true);
    }
    private void ringcontrol1()
    {
        int putcontrol = PlayerPrefs.GetInt("buy1");
        if (putcontrol == 1)
        {
            putonButton[1].SetActive(true);
        }
    }
    private void ringcontrol2()
    {
        int putcontrol = PlayerPrefs.GetInt("buy2");
        if (putcontrol == 1)
        {
            putonButton[2].SetActive(true);
        }
    }
    private void ringcontrol3()
    {
        int putcontrol = PlayerPrefs.GetInt("buy3");
        if (putcontrol == 1)
        {
            putonButton[3].SetActive(true);
        }
    }
    private void ringcontrol4()
    {
        int putcontrol = PlayerPrefs.GetInt("buy4");
        if (putcontrol == 1)
        {
            putonButton[4].SetActive(true);
        }
    }
    private void ringcontrol5()
    {
        int putcontrol = PlayerPrefs.GetInt("buy5");
        if (putcontrol == 1)
        {
            putonButton[5].SetActive(true);
        }
    }
    private void ringcontrol6()
    {
        int putcontrol = PlayerPrefs.GetInt("buy6");
        if (putcontrol == 1)
        {
            putonButton[6].SetActive(true);
        }
    }
    private void ringcontrol7()
    {
        int putcontrol = PlayerPrefs.GetInt("buy7");
        if (putcontrol == 1)
        {
            putonButton[7].SetActive(true);
        }
    }
    private void ringcontrol8()
    {
        int putcontrol = PlayerPrefs.GetInt("buy8");
        if (putcontrol == 1)
        {
            putonButton[8].SetActive(true);
        }
    }

    public void putOn1()
    {
        putonButton[0].SetActive(false);
        ringcontrol1();
        ringcontrol2();
        ringcontrol3();
        ringcontrol4();
        ringcontrol5();
        ringcontrol6();
        ringcontrol7();
        ringcontrol8();

        s0.color = Color.green;
        s1.color = new Color32(178, 131, 250, 100);
        s2.color = new Color32(178, 131, 250, 100);
        s3.color = new Color32(178, 131, 250, 100);
        s4.color = new Color32(178, 131, 250, 100);
        s5.color = new Color32(178, 131, 250, 100);
        s6.color = new Color32(178, 131, 250, 100);
        s7.color = new Color32(178, 131, 250, 100);
        s8.color = new Color32(178, 131, 250, 100);
        PlayerPrefs.SetInt("getPlayers", 0);
        animshopPlayer[0].SetBool("Stopstart" , true);
        if (animsayac != 0)
        {
            animshopPlayer[0].SetTrigger("Flip");
        }
        animsayac++;
        destroyGameobject = GameObject.FindGameObjectWithTag("Player");
        Destroy(destroyGameobject);
        previous_playerNew = Instantiate(playerNew[0], Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f -7f + 0.08170986f), Quaternion.Euler(90f, 0f, -90f));
        previous_playerNew.transform.parent = Camera.main.transform;
    }
    public void putOn2()
    {
        ringcontrol0();
        putonButton[1].SetActive(false);
        ringcontrol2();
        ringcontrol3();
        ringcontrol4();
        ringcontrol5();
        ringcontrol6();
        ringcontrol7();
        ringcontrol8();

        s0.color = new Color32(178, 131, 250, 100);
        s1.color = Color.green;
        s2.color = new Color32(178, 131, 250, 100);
        s3.color = new Color32(178, 131, 250, 100);
        s4.color = new Color32(178, 131, 250, 100);
        s5.color = new Color32(178, 131, 250, 100);
        s6.color = new Color32(178, 131, 250, 100);
        s7.color = new Color32(178, 131, 250, 100);
        s8.color = new Color32(178, 131, 250, 100);
        PlayerPrefs.SetInt("getPlayers", 1);
        animshopPlayer[1].SetBool("Stopstart1", true);
        if (animsayac1 != 0)
        {
            animshopPlayer[1].SetTrigger("ring1");
        }
        animsayac1++;
        destroyGameobject = GameObject.FindGameObjectWithTag("Player");
        Destroy(destroyGameobject);
        previous_playerNew = Instantiate(playerNew[1], Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f), Quaternion.Euler(90f, 0f, 0f));
        previous_playerNew.transform.parent = Camera.main.transform;
    }
    public void putOn3()
    {
        ringcontrol0();
        ringcontrol1();
        putonButton[2].SetActive(false);
        ringcontrol3();
        ringcontrol4();
        ringcontrol5();
        ringcontrol6();
        ringcontrol7();
        ringcontrol8();

        s0.color = new Color32(178, 131, 250, 100);
        s1.color = new Color32(178, 131, 250, 100);
        s2.color = Color.green;
        s3.color = new Color32(178, 131, 250, 100);
        s4.color = new Color32(178, 131, 250, 100);
        s5.color = new Color32(178, 131, 250, 100);
        s6.color = new Color32(178, 131, 250, 100);
        s7.color = new Color32(178, 131, 250, 100);
        s8.color = new Color32(178, 131, 250, 100);
        PlayerPrefs.SetInt("getPlayers", 8);
        animshopPlayer[8].SetBool("Stopstart8", true);
        if (animsayac8 != 0)
        {
            animshopPlayer[8].SetTrigger("ring8");
        }
        animsayac8++;
        destroyGameobject = GameObject.FindGameObjectWithTag("Player");
        Destroy(destroyGameobject);
        previous_playerNew = Instantiate(playerNew[8], Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f), Quaternion.Euler(0f, 0f, 0f));
        previous_playerNew.transform.parent = Camera.main.transform;
    }
    public void putOn4()
    {
        ringcontrol0();
        ringcontrol1();
        ringcontrol2();
        putonButton[3].SetActive(false);
        ringcontrol4();
        ringcontrol5();
        ringcontrol6();
        ringcontrol7();
        ringcontrol8();

        s0.color = new Color32(178, 131, 250, 100);
        s1.color = new Color32(178, 131, 250, 100);
        s2.color = new Color32(178, 131, 250, 100);
        s3.color = Color.green;
        s4.color = new Color32(178, 131, 250, 100);
        s5.color = new Color32(178, 131, 250, 100);
        s6.color = new Color32(178, 131, 250, 100);
        s7.color = new Color32(178, 131, 250, 100);
        s8.color = new Color32(178, 131, 250, 100);
        PlayerPrefs.SetInt("getPlayers", 3);
        animshopPlayer[3].SetBool("Stopstart3", true);
        if (animsayac3 != 0)
        {
            animshopPlayer[3].SetTrigger("ring3");
        }
        animsayac3++;
        destroyGameobject = GameObject.FindGameObjectWithTag("Player");
        Destroy(destroyGameobject);
        previous_playerNew = Instantiate(playerNew[3], Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f), Quaternion.Euler(90f, 0f, 0f));
        previous_playerNew.transform.parent = Camera.main.transform;
    }
    public void putOn5()
    {
        ringcontrol0();
        ringcontrol1();
        ringcontrol2();
        ringcontrol3();
        putonButton[4].SetActive(false);
        ringcontrol5();
        ringcontrol6();
        ringcontrol7();
        ringcontrol8();


        s0.color = new Color32(178, 131, 250, 100);
        s1.color = new Color32(178, 131, 250, 100);
        s2.color = new Color32(178, 131, 250, 100);
        s3.color = new Color32(178, 131, 250, 100);
        s4.color = Color.green;
        s5.color = new Color32(178, 131, 250, 100);
        s6.color = new Color32(178, 131, 250, 100);
        s7.color = new Color32(178, 131, 250, 100);
        s8.color = new Color32(178, 131, 250, 100);
        PlayerPrefs.SetInt("getPlayers", 4);
        animshopPlayer[4].SetBool("Stopstart4", true);
        if (animsayac4 != 0)
        {
            animshopPlayer[4].SetTrigger("ring4");
        }
        animsayac4++;
        destroyGameobject = GameObject.FindGameObjectWithTag("Player");
        Destroy(destroyGameobject);
        previous_playerNew = Instantiate(playerNew[4], Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f), Quaternion.Euler(0f, 0f, 0f));
        previous_playerNew.transform.parent = Camera.main.transform;
    }
    public void putOn6()
    {
        ringcontrol0();
        ringcontrol1();
        ringcontrol2();
        ringcontrol3();
        ringcontrol4();
        putonButton[5].SetActive(false);
        ringcontrol6();
        ringcontrol7();
        ringcontrol8();

        s0.color = new Color32(178, 131, 250, 100);
        s1.color = new Color32(178, 131, 250, 100);
        s2.color = new Color32(178, 131, 250, 100);
        s3.color = new Color32(178, 131, 250, 100);
        s4.color = new Color32(178, 131, 250, 100);
        s5.color = Color.green;
        s6.color = new Color32(178, 131, 250, 100);
        s7.color = new Color32(178, 131, 250, 100);
        s8.color = new Color32(178, 131, 250, 100);
        PlayerPrefs.SetInt("getPlayers", 5);
        animshopPlayer[5].SetBool("Stopstart5", true);
        if (animsayac5 != 0)
        {
            animshopPlayer[5].SetTrigger("ring5");
        }
        animsayac5++;
        destroyGameobject = GameObject.FindGameObjectWithTag("Player");
        Destroy(destroyGameobject);
        previous_playerNew = Instantiate(playerNew[5], Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f), Quaternion.Euler(180f, 0f, 0f));
        previous_playerNew.transform.parent = Camera.main.transform;
    }
    public void putOn7()
    {
        ringcontrol0();
        ringcontrol1();
        ringcontrol2();
        ringcontrol3();
        ringcontrol4();
        ringcontrol5();
        putonButton[6].SetActive(false);
        ringcontrol7();
        ringcontrol8();

        s0.color = new Color32(178, 131, 250, 100);
        s1.color = new Color32(178, 131, 250, 100);
        s2.color = new Color32(178, 131, 250, 100);
        s3.color = new Color32(178, 131, 250, 100);
        s4.color = new Color32(178, 131, 250, 100);
        s5.color = new Color32(178, 131, 250, 100);
        s6.color = Color.green;
        s7.color = new Color32(178, 131, 250, 100);
        s8.color = new Color32(178, 131, 250, 100);
        PlayerPrefs.SetInt("getPlayers", 6);
        animshopPlayer[6].SetBool("Stopstart6", true);
        if (animsayac6 != 0)
        {
            animshopPlayer[6].SetTrigger("ring6");
        }
        animsayac6++;
        destroyGameobject = GameObject.FindGameObjectWithTag("Player");
        Destroy(destroyGameobject);
        previous_playerNew = Instantiate(playerNew[6], Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f), Quaternion.Euler(0f, 0f, 180f));
        previous_playerNew.transform.parent = Camera.main.transform;
    }
    public void putOn8()
    {
        ringcontrol0();
        ringcontrol1();
        ringcontrol2();
        ringcontrol3();
        ringcontrol4();
        ringcontrol5();
        ringcontrol6();
        putonButton[7].SetActive(false);
        ringcontrol8();

        s0.color = new Color32(178, 131, 250, 100);
        s1.color = new Color32(178, 131, 250, 100);
        s2.color = new Color32(178, 131, 250, 100);
        s3.color = new Color32(178, 131, 250, 100);
        s4.color = new Color32(178, 131, 250, 100);
        s5.color = new Color32(178, 131, 250, 100);
        s6.color = new Color32(178, 131, 250, 100);
        s7.color = Color.green;
        s8.color = new Color32(178, 131, 250, 100);
        PlayerPrefs.SetInt("getPlayers", 7);
        animshopPlayer[7].SetBool("Stopstart7", true);
        if (animsayac7 != 0)
        {
            animshopPlayer[7].SetTrigger("ring7");
        }
        animsayac7++;
        destroyGameobject = GameObject.FindGameObjectWithTag("Player");
        Destroy(destroyGameobject);
        previous_playerNew = Instantiate(playerNew[7], Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f), Quaternion.Euler(270f, 0f, 180f));
        previous_playerNew.transform.parent = Camera.main.transform;
    }
    public void putOn9()
    {
        ringcontrol0();
        ringcontrol1();
        ringcontrol2();
        ringcontrol3();
        ringcontrol4();
        ringcontrol5();
        ringcontrol6();
        ringcontrol7();
        putonButton[8].SetActive(false);


        s0.color = new Color32(178, 131, 250, 100);
        s1.color = new Color32(178, 131, 250, 100);
        s2.color = new Color32(178, 131, 250, 100);
        s3.color = new Color32(178, 131, 250, 100);
        s4.color = new Color32(178, 131, 250, 100);
        s5.color = new Color32(178, 131, 250, 100);
        s6.color = new Color32(178, 131, 250, 100);
        s7.color = new Color32(178, 131, 250, 100);
        s8.color = Color.green;
        PlayerPrefs.SetInt("getPlayers", 2);
        animshopPlayer[2].SetBool("Stopstart2", true);
        if (animsayac2 != 0)
        {
            animshopPlayer[2].SetTrigger("ring2");
        }
        animsayac2++;
        destroyGameobject = GameObject.FindGameObjectWithTag("Player");
        Destroy(destroyGameobject);
        previous_playerNew = Instantiate(playerNew[2], Camera.main.transform.position + new Vector3(0, -17.7855538f + 5.755553f, 13.91829f - 7f + 0.08170986f), Quaternion.Euler(270f, 0f, 0f));
        previous_playerNew.transform.parent = Camera.main.transform;
    }


    public void buyCylinder1()
    {
        if (puanim.wood >= 75)
        {
            PlayerPrefs.SetInt("buyc1", 1);
            buyButton1[0].SetActive(false);
            goldimage1[0].SetActive(false);
            buytext1[0].SetActive(false);
            puanim.wood -= 75;
            puanScripti.buyWood();
            putonButton1[1].SetActive(true);
        }
        else
        {
            cameram.PlayOneShot(nomany, 1f);
        }
    }
    public void buyCylinder2()
    {
        if (puanim.wood >= 200)
        {
            PlayerPrefs.SetInt("buyc2", 1);
            buyButton1[1].SetActive(false);
            goldimage1[1].SetActive(false);
            buytext1[1].SetActive(false);
            puanim.wood -= 200;
            puanScripti.buyWood();
            putonButton1[2].SetActive(true);
        }
        else
        {
            cameram.PlayOneShot(nomany, 1f);
        }
    }

    public void buyCylinder3()
    {
        if (puanim.wood >= 350)
        {
            PlayerPrefs.SetInt("buyc3", 1);
            buyButton1[2].SetActive(false);
            goldimage1[2].SetActive(false);
            buytext1[2].SetActive(false);
            puanim.wood -= 350;
            puanScripti.buyWood();
            putonButton1[3].SetActive(true);
        }
        else
        {
            cameram.PlayOneShot(nomany, 1f);
        }
    }
    public void buyCylinder4()
    {
        if (puanim.wood >= 500)
        {
            PlayerPrefs.SetInt("buyc4", 1);
            buyButton1[3].SetActive(false);
            goldimage1[3].SetActive(false);
            buytext1[3].SetActive(false);
            puanim.wood -= 500;
            puanScripti.buyWood();
            putonButton1[4].SetActive(true);
        }
        else
        {
            cameram.PlayOneShot(nomany, 1f);
        }
    }
    public void buyCylinder5()
    {
        if (puanim.wood >= 675)
        {
            PlayerPrefs.SetInt("buyc5", 1);
            buyButton1[4].SetActive(false);
            goldimage1[4].SetActive(false);
            buytext1[4].SetActive(false);
            puanim.wood -= 675;
            puanScripti.buyWood();
            putonButton1[5].SetActive(true);
        }
        else
        {
            cameram.PlayOneShot(nomany, 1f);
        }
    }
    public void buyCylinder6()
    {
        if (puanim.wood >= 850)
        {
            PlayerPrefs.SetInt("buyc6", 1);
            buyButton1[5].SetActive(false);
            goldimage1[5].SetActive(false);
            buytext1[5].SetActive(false);
            puanim.wood -= 850;
            puanScripti.buyWood();
            putonButton1[6].SetActive(true);
        }
        else
        {
            cameram.PlayOneShot(nomany, 1f);
        }
    }
    public void buyCylinder7()
    {
        if (puanim.wood >= 1250)
        {
            PlayerPrefs.SetInt("buyc7", 1);
            buyButton1[6].SetActive(false);
            goldimage1[6].SetActive(false);
            buytext1[6].SetActive(false);
            puanim.wood -= 1250;
            puanScripti.buyWood();
            putonButton1[7].SetActive(true);
        }
        else
        {
            cameram.PlayOneShot(nomany, 1f);
        }
    }
    public void buyCylinder8()
    {
        if (puanim.wood >= 2500)
        {
            PlayerPrefs.SetInt("buyc8", 1);
            buyButton1[7].SetActive(false);
            goldimage1[7].SetActive(false);
            buytext1[7].SetActive(false);
            puanim.wood -= 2500;
            puanScripti.buyWood();
            putonButton1[8].SetActive(true);
        }
        else
        {
            cameram.PlayOneShot(nomany, 1f);
        }
    }

    private void cylcontrol0()
    {
        putonButton1[0].SetActive(true);
    }
    private void cylcontrol1()
    {
        int putcontrol = PlayerPrefs.GetInt("buyc1");
        if (putcontrol == 1)
        {
            putonButton1[1].SetActive(true);
        }
    }
    private void cylcontrol2()
    {
        int putcontrol = PlayerPrefs.GetInt("buyc2");
        if (putcontrol == 1)
        {
            putonButton1[2].SetActive(true);
        }
    }
    private void cylcontrol3()
    {
        int putcontrol = PlayerPrefs.GetInt("buyc3");
        if (putcontrol == 1)
        {
            putonButton1[3].SetActive(true);
        }
    }
    private void cylcontrol4()
    {
        int putcontrol = PlayerPrefs.GetInt("buyc4");
        if (putcontrol == 1)
        {
            putonButton1[4].SetActive(true);
        }
    }
    private void cylcontrol5()
    {
        int putcontrol = PlayerPrefs.GetInt("buyc5");
        if (putcontrol == 1)
        {
            putonButton1[5].SetActive(true);
        }
    }
    private void cylcontrol6()
    {
        int putcontrol = PlayerPrefs.GetInt("buyc6");
        if (putcontrol == 1)
        {
            putonButton1[6].SetActive(true);
        }
    }
    private void cylcontrol7()
    {
        int putcontrol = PlayerPrefs.GetInt("buyc7");
        if (putcontrol == 1)
        {
            putonButton1[7].SetActive(true);
        }
    }
    private void cylcontrol8()
    {
        int putcontrol = PlayerPrefs.GetInt("buyc8");
        if (putcontrol == 1)
        {
            putonButton1[8].SetActive(true);
        }
    }

    public void WoodputOn1()
    {
        putonButton1[0].SetActive(false);
        cylcontrol1();
        cylcontrol2();
        cylcontrol3();
        cylcontrol4();
        cylcontrol5();
        cylcontrol6();
        cylcontrol7();
        cylcontrol8();

        c0.color = Color.green;
        c1.color = new Color32(178, 131, 250, 100);
        c2.color = new Color32(178, 131, 250, 100);
        c3.color = new Color32(178, 131, 250, 100);
        c4.color = new Color32(178, 131, 250, 100);
        c5.color = new Color32(178, 131, 250, 100);
        c6.color = new Color32(178, 131, 250, 100);
        c7.color = new Color32(178, 131, 250, 100);
        c8.color = new Color32(178, 131, 250, 100);
        cylrenderer.sharedMaterial = materials[6];
        branchrenderer.sharedMaterial = materials[6];
        particlerenderer.sharedMaterial = materials[6];
        finishedmesh.sharedMaterial= materials[6];
        PlayerPrefs.SetInt("getCylinders", 0);

        if (startwood1 == true)
        {
            MeshRenderer abcdef = GameObject.FindGameObjectWithTag("wall").GetComponent<MeshRenderer>();
            abcdef.sharedMaterial = materials[6];
            int branc = 0;
            for (int bw = 0; bw < 26; bw++)
            {
                try
                {
                    GameObject qwe = GameObject.FindGameObjectsWithTag("branch")[bw];
                    branc++;
                }
                catch (System.Exception)
                {
                    break;
                }
            }
            #region currentlevel
            if (currentlevel == 1)
            {
                for (int ka = 0; ka < (LevelGenerator.lv.windowtreenumber + 1) - LevelGenerator.lv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 2)
            {
                for (int ka = 0; ka < (LLevelGenerator.llv.windowtreenumber + 1) - LLevelGenerator.llv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 3)
            {
                for (int ka = 0; ka < (l3.windowtreenumber + 1) - l3.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 4)
            {
                for (int ka = 0; ka < (l4.windowtreenumber + 1) - l4.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 5)
            {
                for (int ka = 0; ka < (l5.windowtreenumber + 1) - l5.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 6)
            {
                for (int ka = 0; ka < (l6.windowtreenumber + 1) - l6.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 7)
            {
                for (int ka = 0; ka < (l7.windowtreenumber + 1) - l7.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 8)
            {
                for (int ka = 0; ka < (l8.windowtreenumber + 1) - l8.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 9)
            {
                for (int ka = 0; ka < (l9.windowtreenumber + 1) - l9.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 10)
            {
                for (int ka = 0; ka < (l10.windowtreenumber + 1) - l10.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 11)
            {
                for (int ka = 0; ka < (l11.windowtreenumber + 1) - l11.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 12)
            {
                for (int ka = 0; ka < (l12.windowtreenumber + 1) - l12.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 13)
            {
                for (int ka = 0; ka < (l13.windowtreenumber + 1) - l13.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 14)
            {
                for (int ka = 0; ka < (l14.windowtreenumber + 1) - l14.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 15)
            {
                for (int ka = 0; ka < (l15.windowtreenumber + 1) - l15.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 16)
            {
                for (int ka = 0; ka < (l16.windowtreenumber + 1) - l16.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 17)
            {
                for (int ka = 0; ka < (l17.windowtreenumber + 1) - l17.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 18)
            {
                for (int ka = 0; ka < (l18.windowtreenumber + 1) - l18.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 19)
            {
                for (int ka = 0; ka < (l19.windowtreenumber + 1) - l19.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 20)
            {
                for (int ka = 0; ka < (l20.windowtreenumber + 1) - l20.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 21)
            {
                for (int ka = 0; ka < (l21.windowtreenumber + 1) - l21.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 22)
            {
                for (int ka = 0; ka < (l22.windowtreenumber + 1) - l22.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 23)
            {
                for (int ka = 0; ka < (l23.windowtreenumber + 1) - l23.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 24)
            {
                for (int ka = 0; ka < (l24.windowtreenumber + 1) - l24.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 25)
            {
                for (int ka = 0; ka < (l25.windowtreenumber + 1) - l25.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 26)
            {
                for (int ka = 0; ka < (l26.windowtreenumber + 1) - l26.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 27)
            {
                for (int ka = 0; ka < (l27.windowtreenumber + 1) - l27.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 28)
            {
                for (int ka = 0; ka < (l28.windowtreenumber + 1) - l28.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 29)
            {
                for (int ka = 0; ka < (l29.windowtreenumber + 1) - l29.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 30)
            {
                for (int ka = 0; ka < (l30.windowtreenumber + 1) - l30.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 31)
            {
                for (int ka = 0; ka < (l31.windowtreenumber + 1) - l31.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 32)
            {
                for (int ka = 0; ka < (l32.windowtreenumber + 1) - l32.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 33)
            {
                for (int ka = 0; ka < (l33.windowtreenumber + 1) - l33.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 34)
            {
                for (int ka = 0; ka < (l34.windowtreenumber + 1) - l34.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 35)
            {
                for (int ka = 0; ka < (l35.windowtreenumber + 1) - l35.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 36)
            {
                for (int ka = 0; ka < (l36.windowtreenumber + 1) - l36.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 37)
            {
                for (int ka = 0; ka < (l37.windowtreenumber + 1) - l37.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 38)
            {
                for (int ka = 0; ka < (l38.windowtreenumber + 1) - l38.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 39)
            {
                for (int ka = 0; ka < (l39.windowtreenumber + 1) - l39.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 40)
            {
                for (int ka = 0; ka < (l40.windowtreenumber + 1) - l40.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 41)
            {
                for (int ka = 0; ka < (l41.windowtreenumber + 1) - l41.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 42)
            {
                for (int ka = 0; ka < (l42.windowtreenumber + 1) - l42.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 43)
            {
                for (int ka = 0; ka < (l43.windowtreenumber + 1) - l43.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 44)
            {
                for (int ka = 0; ka < (l44.windowtreenumber + 1) - l44.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 45)
            {
                for (int ka = 0; ka < (l45.windowtreenumber + 1) - l45.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 46)
            {
                for (int ka = 0; ka < (l46.windowtreenumber + 1) - l46.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 47)
            {
                for (int ka = 0; ka < (l47.windowtreenumber + 1) - l47.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 48)
            {
                for (int ka = 0; ka < (l48.windowtreenumber + 1) - l48.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 49)
            {
                for (int ka = 0; ka < (l49.windowtreenumber + 1) - l49.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 50)
            {
                for (int ka = 0; ka < (l50.windowtreenumber + 1) - l50.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            else if (currentlevel == 51)
            {
                for (int ka = 0; ka < (l51.windowtreenumber + 1) - l51.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[6];
                    }
                }
            }
            #endregion
            for (int la = 0; la < branc; la++)
            {
                MeshRenderer ab = GameObject.FindGameObjectsWithTag("branch")[la].GetComponent<MeshRenderer>();
                if (ab != null)
                {
                    ab.sharedMaterial = materials[6];
                }
            }
        }

        if (bug)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void WoodputOn2()
    {
        putonButton1[1].SetActive(false);
        cylcontrol0();
        cylcontrol2();
        cylcontrol3();
        cylcontrol4();
        cylcontrol5();
        cylcontrol6();
        cylcontrol7();
        cylcontrol8();

        c0.color = new Color32(178, 131, 250, 100);
        c1.color = Color.green;
        c2.color = new Color32(178, 131, 250, 100);
        c3.color = new Color32(178, 131, 250, 100);
        c4.color = new Color32(178, 131, 250, 100);
        c5.color = new Color32(178, 131, 250, 100);
        c6.color = new Color32(178, 131, 250, 100);
        c7.color = new Color32(178, 131, 250, 100);
        c8.color = new Color32(178, 131, 250, 100);
        cylrenderer.sharedMaterial = materials[8];
        branchrenderer.sharedMaterial = materials[8];
        particlerenderer.sharedMaterial = materials[8];
        finishedmesh.sharedMaterial = materials[8];
        PlayerPrefs.SetInt("getCylinders", 1);

        if (startwood1 == true)
        {
            MeshRenderer abcdef = GameObject.FindGameObjectWithTag("wall").GetComponent<MeshRenderer>();
            abcdef.sharedMaterial = materials[8];
            int branc = 0;
            for (int bw = 0; bw < 26; bw++)
            {
                try
                {
                    GameObject qwe = GameObject.FindGameObjectsWithTag("branch")[bw];
                    branc++;
                }
                catch (System.Exception)
                {
                    break;
                }
            }

            #region currentlevel
            if (currentlevel == 1)
            {
                for (int ka = 0; ka < (LevelGenerator.lv.windowtreenumber + 1) - LevelGenerator.lv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 2)
            {
                for (int ka = 0; ka < (LLevelGenerator.llv.windowtreenumber + 1) - LLevelGenerator.llv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 3)
            {
                for (int ka = 0; ka < (l3.windowtreenumber + 1) - l3.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 4)
            {
                for (int ka = 0; ka < (l4.windowtreenumber + 1) - l4.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 5)
            {
                for (int ka = 0; ka < (l5.windowtreenumber + 1) - l5.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 6)
            {
                for (int ka = 0; ka < (l6.windowtreenumber + 1) - l6.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 7)
            {
                for (int ka = 0; ka < (l7.windowtreenumber + 1) - l7.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 8)
            {
                for (int ka = 0; ka < (l8.windowtreenumber + 1) - l8.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 9)
            {
                for (int ka = 0; ka < (l9.windowtreenumber + 1) - l9.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 10)
            {
                for (int ka = 0; ka < (l10.windowtreenumber + 1) - l10.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 11)
            {
                for (int ka = 0; ka < (l11.windowtreenumber + 1) - l11.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 12)
            {
                for (int ka = 0; ka < (l12.windowtreenumber + 1) - l12.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 13)
            {
                for (int ka = 0; ka < (l13.windowtreenumber + 1) - l13.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 14)
            {
                for (int ka = 0; ka < (l14.windowtreenumber + 1) - l14.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 15)
            {
                for (int ka = 0; ka < (l15.windowtreenumber + 1) - l15.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 16)
            {
                for (int ka = 0; ka < (l16.windowtreenumber + 1) - l16.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 17)
            {
                for (int ka = 0; ka < (l17.windowtreenumber + 1) - l17.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 18)
            {
                for (int ka = 0; ka < (l18.windowtreenumber + 1) - l18.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 19)
            {
                for (int ka = 0; ka < (l19.windowtreenumber + 1) - l19.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 20)
            {
                for (int ka = 0; ka < (l20.windowtreenumber + 1) - l20.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 21)
            {
                for (int ka = 0; ka < (l21.windowtreenumber + 1) - l21.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 22)
            {
                for (int ka = 0; ka < (l22.windowtreenumber + 1) - l22.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 23)
            {
                for (int ka = 0; ka < (l23.windowtreenumber + 1) - l23.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 24)
            {
                for (int ka = 0; ka < (l24.windowtreenumber + 1) - l24.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 25)
            {
                for (int ka = 0; ka < (l25.windowtreenumber + 1) - l25.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 26)
            {
                for (int ka = 0; ka < (l26.windowtreenumber + 1) - l26.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 27)
            {
                for (int ka = 0; ka < (l27.windowtreenumber + 1) - l27.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 28)
            {
                for (int ka = 0; ka < (l28.windowtreenumber + 1) - l28.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 29)
            {
                for (int ka = 0; ka < (l29.windowtreenumber + 1) - l29.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 30)
            {
                for (int ka = 0; ka < (l30.windowtreenumber + 1) - l30.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 31)
            {
                for (int ka = 0; ka < (l31.windowtreenumber + 1) - l31.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 32)
            {
                for (int ka = 0; ka < (l32.windowtreenumber + 1) - l32.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 33)
            {
                for (int ka = 0; ka < (l33.windowtreenumber + 1) - l33.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 34)
            {
                for (int ka = 0; ka < (l34.windowtreenumber + 1) - l34.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 35)
            {
                for (int ka = 0; ka < (l35.windowtreenumber + 1) - l35.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 36)
            {
                for (int ka = 0; ka < (l36.windowtreenumber + 1) - l36.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 37)
            {
                for (int ka = 0; ka < (l37.windowtreenumber + 1) - l37.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 38)
            {
                for (int ka = 0; ka < (l38.windowtreenumber + 1) - l38.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 39)
            {
                for (int ka = 0; ka < (l39.windowtreenumber + 1) - l39.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 40)
            {
                for (int ka = 0; ka < (l40.windowtreenumber + 1) - l40.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 41)
            {
                for (int ka = 0; ka < (l41.windowtreenumber + 1) - l41.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 42)
            {
                for (int ka = 0; ka < (l42.windowtreenumber + 1) - l42.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 43)
            {
                for (int ka = 0; ka < (l43.windowtreenumber + 1) - l43.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 44)
            {
                for (int ka = 0; ka < (l44.windowtreenumber + 1) - l44.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 45)
            {
                for (int ka = 0; ka < (l45.windowtreenumber + 1) - l45.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 46)
            {
                for (int ka = 0; ka < (l46.windowtreenumber + 1) - l46.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 47)
            {
                for (int ka = 0; ka < (l47.windowtreenumber + 1) - l47.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 48)
            {
                for (int ka = 0; ka < (l48.windowtreenumber + 1) - l48.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 49)
            {
                for (int ka = 0; ka < (l49.windowtreenumber + 1) - l49.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 50)
            {
                for (int ka = 0; ka < (l50.windowtreenumber + 1) - l50.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            else if (currentlevel == 51)
            {
                for (int ka = 0; ka < (l51.windowtreenumber + 1) - l51.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[8];
                    }
                }
            }
            #endregion
            for (int la = 0; la < branc; la++)
            {
                MeshRenderer ab = GameObject.FindGameObjectsWithTag("branch")[la].GetComponent<MeshRenderer>();
                if (ab != null)
                {
                    ab.sharedMaterial = materials[8];
                }
            }
        }

        if (bug)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void WoodputOn3()
    {
        putonButton1[2].SetActive(false);
        cylcontrol1();
        cylcontrol0();
        cylcontrol3();
        cylcontrol4();
        cylcontrol5();
        cylcontrol6();
        cylcontrol7();
        cylcontrol8();

        c0.color = new Color32(178, 131, 250, 100);
        c1.color = new Color32(178, 131, 250, 100);
        c2.color = Color.green;
        c3.color = new Color32(178, 131, 250, 100);
        c4.color = new Color32(178, 131, 250, 100);
        c5.color = new Color32(178, 131, 250, 100);
        c6.color = new Color32(178, 131, 250, 100);
        c7.color = new Color32(178, 131, 250, 100);
        c8.color = new Color32(178, 131, 250, 100);
        cylrenderer.sharedMaterial = materials[2];
        branchrenderer.sharedMaterial = materials[2];
        particlerenderer.sharedMaterial = materials[2];
        finishedmesh.sharedMaterial = materials[2];
        PlayerPrefs.SetInt("getCylinders", 2);

        if (startwood1 == true)
        {
            MeshRenderer abcdef = GameObject.FindGameObjectWithTag("wall").GetComponent<MeshRenderer>();
            abcdef.sharedMaterial = materials[2];
            int branc = 0;
            for (int bw = 0; bw < 26; bw++)
            {
                try
                {
                    GameObject qwe = GameObject.FindGameObjectsWithTag("branch")[bw];
                    branc++;
                }
                catch (System.Exception)
                {
                    break;
                }
            }
            #region currentlevel
            if (currentlevel == 1)
            {
                for (int ka = 0; ka < (LevelGenerator.lv.windowtreenumber + 1) - LevelGenerator.lv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 2)
            {
                for (int ka = 0; ka < (LLevelGenerator.llv.windowtreenumber + 1) - LLevelGenerator.llv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 3)
            {
                for (int ka = 0; ka < (l3.windowtreenumber + 1) - l3.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 4)
            {
                for (int ka = 0; ka < (l4.windowtreenumber + 1) - l4.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 5)
            {
                for (int ka = 0; ka < (l5.windowtreenumber + 1) - l5.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 6)
            {
                for (int ka = 0; ka < (l6.windowtreenumber + 1) - l6.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 7)
            {
                for (int ka = 0; ka < (l7.windowtreenumber + 1) - l7.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 8)
            {
                for (int ka = 0; ka < (l8.windowtreenumber + 1) - l8.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 9)
            {
                for (int ka = 0; ka < (l9.windowtreenumber + 1) - l9.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 10)
            {
                for (int ka = 0; ka < (l10.windowtreenumber + 1) - l10.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 11)
            {
                for (int ka = 0; ka < (l11.windowtreenumber + 1) - l11.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 12)
            {
                for (int ka = 0; ka < (l12.windowtreenumber + 1) - l12.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 13)
            {
                for (int ka = 0; ka < (l13.windowtreenumber + 1) - l13.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 14)
            {
                for (int ka = 0; ka < (l14.windowtreenumber + 1) - l14.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 15)
            {
                for (int ka = 0; ka < (l15.windowtreenumber + 1) - l15.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 16)
            {
                for (int ka = 0; ka < (l16.windowtreenumber + 1) - l16.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 17)
            {
                for (int ka = 0; ka < (l17.windowtreenumber + 1) - l17.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 18)
            {
                for (int ka = 0; ka < (l18.windowtreenumber + 1) - l18.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 19)
            {
                for (int ka = 0; ka < (l19.windowtreenumber + 1) - l19.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 20)
            {
                for (int ka = 0; ka < (l20.windowtreenumber + 1) - l20.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 21)
            {
                for (int ka = 0; ka < (l21.windowtreenumber + 1) - l21.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 22)
            {
                for (int ka = 0; ka < (l22.windowtreenumber + 1) - l22.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 23)
            {
                for (int ka = 0; ka < (l23.windowtreenumber + 1) - l23.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 24)
            {
                for (int ka = 0; ka < (l24.windowtreenumber + 1) - l24.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 25)
            {
                for (int ka = 0; ka < (l25.windowtreenumber + 1) - l25.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 26)
            {
                for (int ka = 0; ka < (l26.windowtreenumber + 1) - l26.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 27)
            {
                for (int ka = 0; ka < (l27.windowtreenumber + 1) - l27.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 28)
            {
                for (int ka = 0; ka < (l28.windowtreenumber + 1) - l28.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 29)
            {
                for (int ka = 0; ka < (l29.windowtreenumber + 1) - l29.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 30)
            {
                for (int ka = 0; ka < (l30.windowtreenumber + 1) - l30.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 31)
            {
                for (int ka = 0; ka < (l31.windowtreenumber + 1) - l31.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 32)
            {
                for (int ka = 0; ka < (l32.windowtreenumber + 1) - l32.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 33)
            {
                for (int ka = 0; ka < (l33.windowtreenumber + 1) - l33.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 34)
            {
                for (int ka = 0; ka < (l34.windowtreenumber + 1) - l34.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 35)
            {
                for (int ka = 0; ka < (l35.windowtreenumber + 1) - l35.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 36)
            {
                for (int ka = 0; ka < (l36.windowtreenumber + 1) - l36.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 37)
            {
                for (int ka = 0; ka < (l37.windowtreenumber + 1) - l37.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 38)
            {
                for (int ka = 0; ka < (l38.windowtreenumber + 1) - l38.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 39)
            {
                for (int ka = 0; ka < (l39.windowtreenumber + 1) - l39.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 40)
            {
                for (int ka = 0; ka < (l40.windowtreenumber + 1) - l40.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 41)
            {
                for (int ka = 0; ka < (l41.windowtreenumber + 1) - l41.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 42)
            {
                for (int ka = 0; ka < (l42.windowtreenumber + 1) - l42.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 43)
            {
                for (int ka = 0; ka < (l43.windowtreenumber + 1) - l43.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 44)
            {
                for (int ka = 0; ka < (l44.windowtreenumber + 1) - l44.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 45)
            {
                for (int ka = 0; ka < (l45.windowtreenumber + 1) - l45.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 46)
            {
                for (int ka = 0; ka < (l46.windowtreenumber + 1) - l46.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 47)
            {
                for (int ka = 0; ka < (l47.windowtreenumber + 1) - l47.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 48)
            {
                for (int ka = 0; ka < (l48.windowtreenumber + 1) - l48.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 49)
            {
                for (int ka = 0; ka < (l49.windowtreenumber + 1) - l49.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 50)
            {
                for (int ka = 0; ka < (l50.windowtreenumber + 1) - l50.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            else if (currentlevel == 51)
            {
                for (int ka = 0; ka < (l51.windowtreenumber + 1) - l51.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[2];
                    }
                }
            }
            #endregion
            for (int la = 0; la < branc; la++)
            {
                MeshRenderer ab = GameObject.FindGameObjectsWithTag("branch")[la].GetComponent<MeshRenderer>();
                if (ab != null)
                {
                    ab.sharedMaterial = materials[2];
                }
            }
        }

        if (bug)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void WoodputOn4()
    {
        putonButton1[3].SetActive(false);
        cylcontrol1();
        cylcontrol2();
        cylcontrol0();
        cylcontrol4();
        cylcontrol5();
        cylcontrol6();
        cylcontrol7();
        cylcontrol8();

        c0.color = new Color32(178, 131, 250, 100);
        c1.color = new Color32(178, 131, 250, 100);
        c2.color = new Color32(178, 131, 250, 100);
        c3.color = Color.green;
        c4.color = new Color32(178, 131, 250, 100);
        c5.color = new Color32(178, 131, 250, 100);
        c6.color = new Color32(178, 131, 250, 100);
        c7.color = new Color32(178, 131, 250, 100);
        c8.color = new Color32(178, 131, 250, 100);
        cylrenderer.sharedMaterial = materials[3];
        branchrenderer.sharedMaterial = materials[3];
        finishedmesh.sharedMaterial = materials[3];
        PlayerPrefs.SetInt("getCylinders", 3);

        if (startwood1 == true)
        {
            MeshRenderer abcdef = GameObject.FindGameObjectWithTag("wall").GetComponent<MeshRenderer>();
            abcdef.sharedMaterial = materials[3];
            int branc = 0;
            for (int bw = 0; bw < 26; bw++)
            {
                try
                {
                    GameObject qwe = GameObject.FindGameObjectsWithTag("branch")[bw];
                    branc++;
                }
                catch (System.Exception)
                {
                    break;
                }
            }

            #region currentlevel
            if (currentlevel == 1)
            {
                for (int ka = 0; ka < (LevelGenerator.lv.windowtreenumber + 1) - LevelGenerator.lv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 2)
            {
                for (int ka = 0; ka < (LLevelGenerator.llv.windowtreenumber + 1) - LLevelGenerator.llv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 3)
            {
                for (int ka = 0; ka < (l3.windowtreenumber + 1) - l3.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 4)
            {
                for (int ka = 0; ka < (l4.windowtreenumber + 1) - l4.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 5)
            {
                for (int ka = 0; ka < (l5.windowtreenumber + 1) - l5.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 6)
            {
                for (int ka = 0; ka < (l6.windowtreenumber + 1) - l6.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 7)
            {
                for (int ka = 0; ka < (l7.windowtreenumber + 1) - l7.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 8)
            {
                for (int ka = 0; ka < (l8.windowtreenumber + 1) - l8.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 9)
            {
                for (int ka = 0; ka < (l9.windowtreenumber + 1) - l9.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 10)
            {
                for (int ka = 0; ka < (l10.windowtreenumber + 1) - l10.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 11)
            {
                for (int ka = 0; ka < (l11.windowtreenumber + 1) - l11.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 12)
            {
                for (int ka = 0; ka < (l12.windowtreenumber + 1) - l12.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 13)
            {
                for (int ka = 0; ka < (l13.windowtreenumber + 1) - l13.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 14)
            {
                for (int ka = 0; ka < (l14.windowtreenumber + 1) - l14.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 15)
            {
                for (int ka = 0; ka < (l15.windowtreenumber + 1) - l15.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 16)
            {
                for (int ka = 0; ka < (l16.windowtreenumber + 1) - l16.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 17)
            {
                for (int ka = 0; ka < (l17.windowtreenumber + 1) - l17.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 18)
            {
                for (int ka = 0; ka < (l18.windowtreenumber + 1) - l18.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 19)
            {
                for (int ka = 0; ka < (l19.windowtreenumber + 1) - l19.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 20)
            {
                for (int ka = 0; ka < (l20.windowtreenumber + 1) - l20.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 21)
            {
                for (int ka = 0; ka < (l21.windowtreenumber + 1) - l21.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 22)
            {
                for (int ka = 0; ka < (l22.windowtreenumber + 1) - l22.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 23)
            {
                for (int ka = 0; ka < (l23.windowtreenumber + 1) - l23.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 24)
            {
                for (int ka = 0; ka < (l24.windowtreenumber + 1) - l24.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 25)
            {
                for (int ka = 0; ka < (l25.windowtreenumber + 1) - l25.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 26)
            {
                for (int ka = 0; ka < (l26.windowtreenumber + 1) - l26.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 27)
            {
                for (int ka = 0; ka < (l27.windowtreenumber + 1) - l27.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 28)
            {
                for (int ka = 0; ka < (l28.windowtreenumber + 1) - l28.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 29)
            {
                for (int ka = 0; ka < (l29.windowtreenumber + 1) - l29.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 30)
            {
                for (int ka = 0; ka < (l30.windowtreenumber + 1) - l30.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 31)
            {
                for (int ka = 0; ka < (l31.windowtreenumber + 1) - l31.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 32)
            {
                for (int ka = 0; ka < (l32.windowtreenumber + 1) - l32.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 33)
            {
                for (int ka = 0; ka < (l33.windowtreenumber + 1) - l33.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 34)
            {
                for (int ka = 0; ka < (l34.windowtreenumber + 1) - l34.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 35)
            {
                for (int ka = 0; ka < (l35.windowtreenumber + 1) - l35.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 36)
            {
                for (int ka = 0; ka < (l36.windowtreenumber + 1) - l36.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 37)
            {
                for (int ka = 0; ka < (l37.windowtreenumber + 1) - l37.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 38)
            {
                for (int ka = 0; ka < (l38.windowtreenumber + 1) - l38.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 39)
            {
                for (int ka = 0; ka < (l39.windowtreenumber + 1) - l39.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 40)
            {
                for (int ka = 0; ka < (l40.windowtreenumber + 1) - l40.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 41)
            {
                for (int ka = 0; ka < (l41.windowtreenumber + 1) - l41.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 42)
            {
                for (int ka = 0; ka < (l42.windowtreenumber + 1) - l42.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 43)
            {
                for (int ka = 0; ka < (l43.windowtreenumber + 1) - l43.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 44)
            {
                for (int ka = 0; ka < (l44.windowtreenumber + 1) - l44.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 45)
            {
                for (int ka = 0; ka < (l45.windowtreenumber + 1) - l45.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 46)
            {
                for (int ka = 0; ka < (l46.windowtreenumber + 1) - l46.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 47)
            {
                for (int ka = 0; ka < (l47.windowtreenumber + 1) - l47.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 48)
            {
                for (int ka = 0; ka < (l48.windowtreenumber + 1) - l48.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 49)
            {
                for (int ka = 0; ka < (l49.windowtreenumber + 1) - l49.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 50)
            {
                for (int ka = 0; ka < (l50.windowtreenumber + 1) - l50.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            else if (currentlevel == 51)
            {
                for (int ka = 0; ka < (l51.windowtreenumber + 1) - l51.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[3];
                    }
                }
            }
            #endregion

            for (int la = 0; la < branc; la++)
            {
                MeshRenderer ab = GameObject.FindGameObjectsWithTag("branch")[la].GetComponent<MeshRenderer>();
                if (ab != null)
                {
                    ab.sharedMaterial = materials[3];
                }
            }
        }

        if (bug)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void WoodputOn5()
    {
        putonButton1[4].SetActive(false);
        cylcontrol1();
        cylcontrol2();
        cylcontrol3();
        cylcontrol0();
        cylcontrol5();
        cylcontrol6();
        cylcontrol7();
        cylcontrol8();

        c0.color = new Color32(178, 131, 250, 100);
        c1.color = new Color32(178, 131, 250, 100);
        c2.color = new Color32(178, 131, 250, 100);
        c3.color = new Color32(178, 131, 250, 100);
        c4.color = Color.green;
        c5.color = new Color32(178, 131, 250, 100);
        c6.color = new Color32(178, 131, 250, 100);
        c7.color = new Color32(178, 131, 250, 100);
        c8.color = new Color32(178, 131, 250, 100);
        cylrenderer.sharedMaterial = materials[4];
        branchrenderer.sharedMaterial = materials[4];
        finishedmesh.sharedMaterial = materials[4];
        PlayerPrefs.SetInt("getCylinders", 4);

        if (startwood1 == true)
        {
            MeshRenderer abcdef = GameObject.FindGameObjectWithTag("wall").GetComponent<MeshRenderer>();
            abcdef.sharedMaterial = materials[4];
            int branc = 0;
            for (int bw = 0; bw < 26; bw++)
            {
                try
                {
                    GameObject qwe = GameObject.FindGameObjectsWithTag("branch")[bw];
                    branc++;
                }
                catch (System.Exception)
                {
                    break;
                }
            }

            #region currentlevel
            if (currentlevel == 1)
            {
                for (int ka = 0; ka < (LevelGenerator.lv.windowtreenumber + 1) - LevelGenerator.lv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 2)
            {
                for (int ka = 0; ka < (LLevelGenerator.llv.windowtreenumber + 1) - LLevelGenerator.llv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 3)
            {
                for (int ka = 0; ka < (l3.windowtreenumber + 1) - l3.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 4)
            {
                for (int ka = 0; ka < (l4.windowtreenumber + 1) - l4.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 5)
            {
                for (int ka = 0; ka < (l5.windowtreenumber + 1) - l5.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 6)
            {
                for (int ka = 0; ka < (l6.windowtreenumber + 1) - l6.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 7)
            {
                for (int ka = 0; ka < (l7.windowtreenumber + 1) - l7.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 8)
            {
                for (int ka = 0; ka < (l8.windowtreenumber + 1) - l8.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 9)
            {
                for (int ka = 0; ka < (l9.windowtreenumber + 1) - l9.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 10)
            {
                for (int ka = 0; ka < (l10.windowtreenumber + 1) - l10.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 11)
            {
                for (int ka = 0; ka < (l11.windowtreenumber + 1) - l11.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 12)
            {
                for (int ka = 0; ka < (l12.windowtreenumber + 1) - l12.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 13)
            {
                for (int ka = 0; ka < (l13.windowtreenumber + 1) - l13.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 14)
            {
                for (int ka = 0; ka < (l14.windowtreenumber + 1) - l14.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 15)
            {
                for (int ka = 0; ka < (l15.windowtreenumber + 1) - l15.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 16)
            {
                for (int ka = 0; ka < (l16.windowtreenumber + 1) - l16.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 17)
            {
                for (int ka = 0; ka < (l17.windowtreenumber + 1) - l17.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 18)
            {
                for (int ka = 0; ka < (l18.windowtreenumber + 1) - l18.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 19)
            {
                for (int ka = 0; ka < (l19.windowtreenumber + 1) - l19.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 20)
            {
                for (int ka = 0; ka < (l20.windowtreenumber + 1) - l20.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 21)
            {
                for (int ka = 0; ka < (l21.windowtreenumber + 1) - l21.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 22)
            {
                for (int ka = 0; ka < (l22.windowtreenumber + 1) - l22.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 23)
            {
                for (int ka = 0; ka < (l23.windowtreenumber + 1) - l23.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 24)
            {
                for (int ka = 0; ka < (l24.windowtreenumber + 1) - l24.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 25)
            {
                for (int ka = 0; ka < (l25.windowtreenumber + 1) - l25.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 26)
            {
                for (int ka = 0; ka < (l26.windowtreenumber + 1) - l26.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 27)
            {
                for (int ka = 0; ka < (l27.windowtreenumber + 1) - l27.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 28)
            {
                for (int ka = 0; ka < (l28.windowtreenumber + 1) - l28.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 29)
            {
                for (int ka = 0; ka < (l29.windowtreenumber + 1) - l29.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 30)
            {
                for (int ka = 0; ka < (l30.windowtreenumber + 1) - l30.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 31)
            {
                for (int ka = 0; ka < (l31.windowtreenumber + 1) - l31.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 32)
            {
                for (int ka = 0; ka < (l32.windowtreenumber + 1) - l32.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 33)
            {
                for (int ka = 0; ka < (l33.windowtreenumber + 1) - l33.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 34)
            {
                for (int ka = 0; ka < (l34.windowtreenumber + 1) - l34.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 35)
            {
                for (int ka = 0; ka < (l35.windowtreenumber + 1) - l35.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 36)
            {
                for (int ka = 0; ka < (l36.windowtreenumber + 1) - l36.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 37)
            {
                for (int ka = 0; ka < (l37.windowtreenumber + 1) - l37.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 38)
            {
                for (int ka = 0; ka < (l38.windowtreenumber + 1) - l38.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 39)
            {
                for (int ka = 0; ka < (l39.windowtreenumber + 1) - l39.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 40)
            {
                for (int ka = 0; ka < (l40.windowtreenumber + 1) - l40.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 41)
            {
                for (int ka = 0; ka < (l41.windowtreenumber + 1) - l41.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 42)
            {
                for (int ka = 0; ka < (l42.windowtreenumber + 1) - l42.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 43)
            {
                for (int ka = 0; ka < (l43.windowtreenumber + 1) - l43.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 44)
            {
                for (int ka = 0; ka < (l44.windowtreenumber + 1) - l44.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 45)
            {
                for (int ka = 0; ka < (l45.windowtreenumber + 1) - l45.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 46)
            {
                for (int ka = 0; ka < (l46.windowtreenumber + 1) - l46.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 47)
            {
                for (int ka = 0; ka < (l47.windowtreenumber + 1) - l47.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 48)
            {
                for (int ka = 0; ka < (l48.windowtreenumber + 1) - l48.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 49)
            {
                for (int ka = 0; ka < (l49.windowtreenumber + 1) - l49.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 50)
            {
                for (int ka = 0; ka < (l50.windowtreenumber + 1) - l50.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            else if (currentlevel == 51)
            {
                for (int ka = 0; ka < (l51.windowtreenumber + 1) - l51.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[4];
                    }
                }
            }
            #endregion


            for (int la = 0; la < branc; la++)
            {
                MeshRenderer ab = GameObject.FindGameObjectsWithTag("branch")[la].GetComponent<MeshRenderer>();
                if (ab != null)
                {
                    ab.sharedMaterial = materials[4];
                }
            }
        }

        if (bug)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void WoodputOn6()
    {
        putonButton1[5].SetActive(false);
        cylcontrol1();
        cylcontrol2();
        cylcontrol3();
        cylcontrol4();
        cylcontrol0();
        cylcontrol6();
        cylcontrol7();
        cylcontrol8();

        c0.color = new Color32(178, 131, 250, 100);
        c1.color = new Color32(178, 131, 250, 100);
        c2.color = new Color32(178, 131, 250, 100);
        c3.color = new Color32(178, 131, 250, 100);
        c4.color = new Color32(178, 131, 250, 100);
        c5.color = Color.green;
        c6.color = new Color32(178, 131, 250, 100);
        c7.color = new Color32(178, 131, 250, 100);
        c8.color = new Color32(178, 131, 250, 100);
        cylrenderer.sharedMaterial = materials[5];
        branchrenderer.sharedMaterial = materials[5];
        finishedmesh.sharedMaterial = materials[5];
        PlayerPrefs.SetInt("getCylinders", 5);

        if (startwood1 == true)
        {
            MeshRenderer abcdef = GameObject.FindGameObjectWithTag("wall").GetComponent<MeshRenderer>();
            abcdef.sharedMaterial = materials[5];
            int branc = 0;
            for (int bw = 0; bw < 26; bw++)
            {
                try
                {
                    GameObject qwe = GameObject.FindGameObjectsWithTag("branch")[bw];
                    branc++;
                }
                catch (System.Exception)
                {
                    break;
                }
            }

            #region currentlevel
            if (currentlevel == 1)
            {
                for (int ka = 0; ka < (LevelGenerator.lv.windowtreenumber + 1) - LevelGenerator.lv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 2)
            {
                for (int ka = 0; ka < (LLevelGenerator.llv.windowtreenumber + 1) - LLevelGenerator.llv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 3)
            {
                for (int ka = 0; ka < (l3.windowtreenumber + 1) - l3.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 4)
            {
                for (int ka = 0; ka < (l4.windowtreenumber + 1) - l4.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 5)
            {
                for (int ka = 0; ka < (l5.windowtreenumber + 1) - l5.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 6)
            {
                for (int ka = 0; ka < (l6.windowtreenumber + 1) - l6.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 7)
            {
                for (int ka = 0; ka < (l7.windowtreenumber + 1) - l7.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 8)
            {
                for (int ka = 0; ka < (l8.windowtreenumber + 1) - l8.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 9)
            {
                for (int ka = 0; ka < (l9.windowtreenumber + 1) - l9.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 10)
            {
                for (int ka = 0; ka < (l10.windowtreenumber + 1) - l10.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 11)
            {
                for (int ka = 0; ka < (l11.windowtreenumber + 1) - l11.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 12)
            {
                for (int ka = 0; ka < (l12.windowtreenumber + 1) - l12.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 13)
            {
                for (int ka = 0; ka < (l13.windowtreenumber + 1) - l13.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 14)
            {
                for (int ka = 0; ka < (l14.windowtreenumber + 1) - l14.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 15)
            {
                for (int ka = 0; ka < (l15.windowtreenumber + 1) - l15.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 16)
            {
                for (int ka = 0; ka < (l16.windowtreenumber + 1) - l16.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 17)
            {
                for (int ka = 0; ka < (l17.windowtreenumber + 1) - l17.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 18)
            {
                for (int ka = 0; ka < (l18.windowtreenumber + 1) - l18.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 19)
            {
                for (int ka = 0; ka < (l19.windowtreenumber + 1) - l19.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 20)
            {
                for (int ka = 0; ka < (l20.windowtreenumber + 1) - l20.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 21)
            {
                for (int ka = 0; ka < (l21.windowtreenumber + 1) - l21.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 22)
            {
                for (int ka = 0; ka < (l22.windowtreenumber + 1) - l22.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 23)
            {
                for (int ka = 0; ka < (l23.windowtreenumber + 1) - l23.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 24)
            {
                for (int ka = 0; ka < (l24.windowtreenumber + 1) - l24.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 25)
            {
                for (int ka = 0; ka < (l25.windowtreenumber + 1) - l25.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 26)
            {
                for (int ka = 0; ka < (l26.windowtreenumber + 1) - l26.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 27)
            {
                for (int ka = 0; ka < (l27.windowtreenumber + 1) - l27.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 28)
            {
                for (int ka = 0; ka < (l28.windowtreenumber + 1) - l28.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 29)
            {
                for (int ka = 0; ka < (l29.windowtreenumber + 1) - l29.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 30)
            {
                for (int ka = 0; ka < (l30.windowtreenumber + 1) - l30.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 31)
            {
                for (int ka = 0; ka < (l31.windowtreenumber + 1) - l31.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 32)
            {
                for (int ka = 0; ka < (l32.windowtreenumber + 1) - l32.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 33)
            {
                for (int ka = 0; ka < (l33.windowtreenumber + 1) - l33.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 34)
            {
                for (int ka = 0; ka < (l34.windowtreenumber + 1) - l34.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 35)
            {
                for (int ka = 0; ka < (l35.windowtreenumber + 1) - l35.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 36)
            {
                for (int ka = 0; ka < (l36.windowtreenumber + 1) - l36.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 37)
            {
                for (int ka = 0; ka < (l37.windowtreenumber + 1) - l37.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 38)
            {
                for (int ka = 0; ka < (l38.windowtreenumber + 1) - l38.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 39)
            {
                for (int ka = 0; ka < (l39.windowtreenumber + 1) - l39.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 40)
            {
                for (int ka = 0; ka < (l40.windowtreenumber + 1) - l40.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 41)
            {
                for (int ka = 0; ka < (l41.windowtreenumber + 1) - l41.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 42)
            {
                for (int ka = 0; ka < (l42.windowtreenumber + 1) - l42.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 43)
            {
                for (int ka = 0; ka < (l43.windowtreenumber + 1) - l43.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 44)
            {
                for (int ka = 0; ka < (l44.windowtreenumber + 1) - l44.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 45)
            {
                for (int ka = 0; ka < (l45.windowtreenumber + 1) - l45.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 46)
            {
                for (int ka = 0; ka < (l46.windowtreenumber + 1) - l46.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 47)
            {
                for (int ka = 0; ka < (l47.windowtreenumber + 1) - l47.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 48)
            {
                for (int ka = 0; ka < (l48.windowtreenumber + 1) - l48.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 49)
            {
                for (int ka = 0; ka < (l49.windowtreenumber + 1) - l49.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 50)
            {
                for (int ka = 0; ka < (l50.windowtreenumber + 1) - l50.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            else if (currentlevel == 51)
            {
                for (int ka = 0; ka < (l51.windowtreenumber + 1) - l51.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[5];
                    }
                }
            }
            #endregion



            for (int la = 0; la < branc; la++)
            {
                MeshRenderer ab = GameObject.FindGameObjectsWithTag("branch")[la].GetComponent<MeshRenderer>();
                if (ab != null)
                {
                    ab.sharedMaterial = materials[5];
                }
            }
        }
        if (bug)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void WoodputOn7()
    {
        putonButton1[6].SetActive(false);
        cylcontrol1();
        cylcontrol2();
        cylcontrol3();
        cylcontrol4();
        cylcontrol5();
        cylcontrol0();
        cylcontrol7();
        cylcontrol8();

        c0.color = new Color32(178, 131, 250, 100);
        c1.color = new Color32(178, 131, 250, 100);
        c2.color = new Color32(178, 131, 250, 100);
        c3.color = new Color32(178, 131, 250, 100);
        c4.color = new Color32(178, 131, 250, 100);
        c5.color = new Color32(178, 131, 250, 100);
        c6.color = Color.green;
        c7.color = new Color32(178, 131, 250, 100);
        c8.color = new Color32(178, 131, 250, 100);
        cylrenderer.sharedMaterial = materials[0];
        branchrenderer.sharedMaterial = materials[0];
        finishedmesh.sharedMaterial = materials[0];
        PlayerPrefs.SetInt("getCylinders", 6);

        if (startwood1 == true)
        {
            MeshRenderer abcdef = GameObject.FindGameObjectWithTag("wall").GetComponent<MeshRenderer>();
            abcdef.sharedMaterial = materials[0];
            int branc = 0;
            for (int bw = 0; bw < 26; bw++)
            {
                try
                {
                    GameObject qwe = GameObject.FindGameObjectsWithTag("branch")[bw];
                    branc++;
                }
                catch (System.Exception)
                {
                    break;
                }
            }

            #region currentlevel
            if (currentlevel == 1)
            {
                for (int ka = 0; ka < (LevelGenerator.lv.windowtreenumber + 1) - LevelGenerator.lv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 2)
            {
                for (int ka = 0; ka < (LLevelGenerator.llv.windowtreenumber + 1) - LLevelGenerator.llv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 3)
            {
                for (int ka = 0; ka < (l3.windowtreenumber + 1) - l3.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 4)
            {
                for (int ka = 0; ka < (l4.windowtreenumber + 1) - l4.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 5)
            {
                for (int ka = 0; ka < (l5.windowtreenumber + 1) - l5.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 6)
            {
                for (int ka = 0; ka < (l6.windowtreenumber + 1) - l6.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 7)
            {
                for (int ka = 0; ka < (l7.windowtreenumber + 1) - l7.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 8)
            {
                for (int ka = 0; ka < (l8.windowtreenumber + 1) - l8.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 9)
            {
                for (int ka = 0; ka < (l9.windowtreenumber + 1) - l9.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 10)
            {
                for (int ka = 0; ka < (l10.windowtreenumber + 1) - l10.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 11)
            {
                for (int ka = 0; ka < (l11.windowtreenumber + 1) - l11.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 12)
            {
                for (int ka = 0; ka < (l12.windowtreenumber + 1) - l12.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 13)
            {
                for (int ka = 0; ka < (l13.windowtreenumber + 1) - l13.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 14)
            {
                for (int ka = 0; ka < (l14.windowtreenumber + 1) - l14.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 15)
            {
                for (int ka = 0; ka < (l15.windowtreenumber + 1) - l15.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 16)
            {
                for (int ka = 0; ka < (l16.windowtreenumber + 1) - l16.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 17)
            {
                for (int ka = 0; ka < (l17.windowtreenumber + 1) - l17.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 18)
            {
                for (int ka = 0; ka < (l18.windowtreenumber + 1) - l18.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 19)
            {
                for (int ka = 0; ka < (l19.windowtreenumber + 1) - l19.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 20)
            {
                for (int ka = 0; ka < (l20.windowtreenumber + 1) - l20.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 21)
            {
                for (int ka = 0; ka < (l21.windowtreenumber + 1) - l21.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 22)
            {
                for (int ka = 0; ka < (l22.windowtreenumber + 1) - l22.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 23)
            {
                for (int ka = 0; ka < (l23.windowtreenumber + 1) - l23.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 24)
            {
                for (int ka = 0; ka < (l24.windowtreenumber + 1) - l24.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 25)
            {
                for (int ka = 0; ka < (l25.windowtreenumber + 1) - l25.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 26)
            {
                for (int ka = 0; ka < (l26.windowtreenumber + 1) - l26.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 27)
            {
                for (int ka = 0; ka < (l27.windowtreenumber + 1) - l27.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 28)
            {
                for (int ka = 0; ka < (l28.windowtreenumber + 1) - l28.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 29)
            {
                for (int ka = 0; ka < (l29.windowtreenumber + 1) - l29.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 30)
            {
                for (int ka = 0; ka < (l30.windowtreenumber + 1) - l30.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 31)
            {
                for (int ka = 0; ka < (l31.windowtreenumber + 1) - l31.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 32)
            {
                for (int ka = 0; ka < (l32.windowtreenumber + 1) - l32.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 33)
            {
                for (int ka = 0; ka < (l33.windowtreenumber + 1) - l33.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 34)
            {
                for (int ka = 0; ka < (l34.windowtreenumber + 1) - l34.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 35)
            {
                for (int ka = 0; ka < (l35.windowtreenumber + 1) - l35.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 36)
            {
                for (int ka = 0; ka < (l36.windowtreenumber + 1) - l36.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 37)
            {
                for (int ka = 0; ka < (l37.windowtreenumber + 1) - l37.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 38)
            {
                for (int ka = 0; ka < (l38.windowtreenumber + 1) - l38.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 39)
            {
                for (int ka = 0; ka < (l39.windowtreenumber + 1) - l39.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 40)
            {
                for (int ka = 0; ka < (l40.windowtreenumber + 1) - l40.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 41)
            {
                for (int ka = 0; ka < (l41.windowtreenumber + 1) - l41.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 42)
            {
                for (int ka = 0; ka < (l42.windowtreenumber + 1) - l42.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 43)
            {
                for (int ka = 0; ka < (l43.windowtreenumber + 1) - l43.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 44)
            {
                for (int ka = 0; ka < (l44.windowtreenumber + 1) - l44.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 45)
            {
                for (int ka = 0; ka < (l45.windowtreenumber + 1) - l45.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 46)
            {
                for (int ka = 0; ka < (l46.windowtreenumber + 1) - l46.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 47)
            {
                for (int ka = 0; ka < (l47.windowtreenumber + 1) - l47.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 48)
            {
                for (int ka = 0; ka < (l48.windowtreenumber + 1) - l48.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 49)
            {
                for (int ka = 0; ka < (l49.windowtreenumber + 1) - l49.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 50)
            {
                for (int ka = 0; ka < (l50.windowtreenumber + 1) - l50.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            else if (currentlevel == 51)
            {
                for (int ka = 0; ka < (l51.windowtreenumber + 1) - l51.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[0];
                    }
                }
            }
            #endregion



            for (int la = 0; la < branc; la++)
            {
                MeshRenderer ab = GameObject.FindGameObjectsWithTag("branch")[la].GetComponent<MeshRenderer>();
                if (ab != null)
                {
                    ab.sharedMaterial = materials[0];
                }
            }
        }

        if (bug)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void WoodputOn8()
    {
        putonButton1[7].SetActive(false);
        cylcontrol1();
        cylcontrol2();
        cylcontrol3();
        cylcontrol4();
        cylcontrol5();
        cylcontrol6();
        cylcontrol0();
        cylcontrol8();

        c0.color = new Color32(178, 131, 250, 100);
        c1.color = new Color32(178, 131, 250, 100);
        c2.color = new Color32(178, 131, 250, 100);
        c3.color = new Color32(178, 131, 250, 100);
        c4.color = new Color32(178, 131, 250, 100);
        c5.color = new Color32(178, 131, 250, 100);
        c6.color = new Color32(178, 131, 250, 100);
        c7.color = Color.green;
        c8.color = new Color32(178, 131, 250, 100);
        cylrenderer.sharedMaterial = materials[7];
        branchrenderer.sharedMaterial = materials[7];
        finishedmesh.sharedMaterial = materials[7];
        PlayerPrefs.SetInt("getCylinders", 7);

        if (startwood1 == true)
        {
            MeshRenderer abcdef = GameObject.FindGameObjectWithTag("wall").GetComponent<MeshRenderer>();
            abcdef.sharedMaterial = materials[7];
            int branc = 0;
            for (int bw = 0; bw < 26; bw++)
            {
                try
                {
                    GameObject qwe = GameObject.FindGameObjectsWithTag("branch")[bw];
                    branc++;
                }
                catch (System.Exception)
                {
                    break;
                }
            }

            #region currentlevel
            if (currentlevel == 1)
            {
                for (int ka = 0; ka < (LevelGenerator.lv.windowtreenumber + 1) - LevelGenerator.lv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 2)
            {
                for (int ka = 0; ka < (LLevelGenerator.llv.windowtreenumber + 1) - LLevelGenerator.llv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 3)
            {
                for (int ka = 0; ka < (l3.windowtreenumber + 1) - l3.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 4)
            {
                for (int ka = 0; ka < (l4.windowtreenumber + 1) - l4.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 5)
            {
                for (int ka = 0; ka < (l5.windowtreenumber + 1) - l5.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 6)
            {
                for (int ka = 0; ka < (l6.windowtreenumber + 1) - l6.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 7)
            {
                for (int ka = 0; ka < (l7.windowtreenumber + 1) - l7.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 8)
            {
                for (int ka = 0; ka < (l8.windowtreenumber + 1) - l8.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 9)
            {
                for (int ka = 0; ka < (l9.windowtreenumber + 1) - l9.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 10)
            {
                for (int ka = 0; ka < (l10.windowtreenumber + 1) - l10.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 11)
            {
                for (int ka = 0; ka < (l11.windowtreenumber + 1) - l11.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 12)
            {
                for (int ka = 0; ka < (l12.windowtreenumber + 1) - l12.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 13)
            {
                for (int ka = 0; ka < (l13.windowtreenumber + 1) - l13.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 14)
            {
                for (int ka = 0; ka < (l14.windowtreenumber + 1) - l14.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 15)
            {
                for (int ka = 0; ka < (l15.windowtreenumber + 1) - l15.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 16)
            {
                for (int ka = 0; ka < (l16.windowtreenumber + 1) - l16.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 17)
            {
                for (int ka = 0; ka < (l17.windowtreenumber + 1) - l17.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 18)
            {
                for (int ka = 0; ka < (l18.windowtreenumber + 1) - l18.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 19)
            {
                for (int ka = 0; ka < (l19.windowtreenumber + 1) - l19.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 20)
            {
                for (int ka = 0; ka < (l20.windowtreenumber + 1) - l20.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 21)
            {
                for (int ka = 0; ka < (l21.windowtreenumber + 1) - l21.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 22)
            {
                for (int ka = 0; ka < (l22.windowtreenumber + 1) - l22.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 23)
            {
                for (int ka = 0; ka < (l23.windowtreenumber + 1) - l23.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 24)
            {
                for (int ka = 0; ka < (l24.windowtreenumber + 1) - l24.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 25)
            {
                for (int ka = 0; ka < (l25.windowtreenumber + 1) - l25.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 26)
            {
                for (int ka = 0; ka < (l26.windowtreenumber + 1) - l26.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 27)
            {
                for (int ka = 0; ka < (l27.windowtreenumber + 1) - l27.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 28)
            {
                for (int ka = 0; ka < (l28.windowtreenumber + 1) - l28.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 29)
            {
                for (int ka = 0; ka < (l29.windowtreenumber + 1) - l29.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 30)
            {
                for (int ka = 0; ka < (l30.windowtreenumber + 1) - l30.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 31)
            {
                for (int ka = 0; ka < (l31.windowtreenumber + 1) - l31.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 32)
            {
                for (int ka = 0; ka < (l32.windowtreenumber + 1) - l32.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 33)
            {
                for (int ka = 0; ka < (l33.windowtreenumber + 1) - l33.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 34)
            {
                for (int ka = 0; ka < (l34.windowtreenumber + 1) - l34.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 35)
            {
                for (int ka = 0; ka < (l35.windowtreenumber + 1) - l35.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 36)
            {
                for (int ka = 0; ka < (l36.windowtreenumber + 1) - l36.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 37)
            {
                for (int ka = 0; ka < (l37.windowtreenumber + 1) - l37.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 38)
            {
                for (int ka = 0; ka < (l38.windowtreenumber + 1) - l38.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 39)
            {
                for (int ka = 0; ka < (l39.windowtreenumber + 1) - l39.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 40)
            {
                for (int ka = 0; ka < (l40.windowtreenumber + 1) - l40.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 41)
            {
                for (int ka = 0; ka < (l41.windowtreenumber + 1) - l41.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 42)
            {
                for (int ka = 0; ka < (l42.windowtreenumber + 1) - l42.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 43)
            {
                for (int ka = 0; ka < (l43.windowtreenumber + 1) - l43.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 44)
            {
                for (int ka = 0; ka < (l44.windowtreenumber + 1) - l44.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 45)
            {
                for (int ka = 0; ka < (l45.windowtreenumber + 1) - l45.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 46)
            {
                for (int ka = 0; ka < (l46.windowtreenumber + 1) - l46.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 47)
            {
                for (int ka = 0; ka < (l47.windowtreenumber + 1) - l47.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 48)
            {
                for (int ka = 0; ka < (l48.windowtreenumber + 1) - l48.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 49)
            {
                for (int ka = 0; ka < (l49.windowtreenumber + 1) - l49.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 50)
            {
                for (int ka = 0; ka < (l50.windowtreenumber + 1) - l50.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            else if (currentlevel == 51)
            {
                for (int ka = 0; ka < (l51.windowtreenumber + 1) - l51.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[7];
                    }
                }
            }
            #endregion


            for (int la = 0; la < branc; la++)
            {
                MeshRenderer ab = GameObject.FindGameObjectsWithTag("branch")[la].GetComponent<MeshRenderer>();
                if (ab != null)
                {
                    ab.sharedMaterial = materials[7];
                }
            }
        }

        if (bug)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void WoodputOn9()
    {
        putonButton1[8].SetActive(false);
        cylcontrol1();
        cylcontrol2();
        cylcontrol3();
        cylcontrol4();
        cylcontrol5();
        cylcontrol6();
        cylcontrol7();
        cylcontrol0();

        c0.color = new Color32(178, 131, 250, 100);
        c1.color = new Color32(178, 131, 250, 100);
        c2.color = new Color32(178, 131, 250, 100);
        c3.color = new Color32(178, 131, 250, 100);
        c4.color = new Color32(178, 131, 250, 100);
        c5.color = new Color32(178, 131, 250, 100);
        c6.color = new Color32(178, 131, 250, 100);
        c7.color = new Color32(178, 131, 250, 100);
        c8.color = Color.green;
        cylrenderer.sharedMaterial = materials[1];
        branchrenderer.sharedMaterial = materials[1];
        finishedmesh.sharedMaterial = materials[1];
        PlayerPrefs.SetInt("getCylinders", 8);

        if (startwood1 == true)
        {
            MeshRenderer abcdef = GameObject.FindGameObjectWithTag("wall").GetComponent<MeshRenderer>();
            abcdef.sharedMaterial = materials[1];
            int branc = 0;
            for (int bw = 0; bw < 26; bw++)
            {
                try
                {
                    GameObject qwe = GameObject.FindGameObjectsWithTag("branch")[bw];
                    branc++;
                }
                catch (System.Exception)
                {
                    break;
                }
            }

            #region currentlevel
            if (currentlevel == 1)
            {
                for (int ka = 0; ka < (LevelGenerator.lv.windowtreenumber + 1) - LevelGenerator.lv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 2)
            {
                for (int ka = 0; ka < (LLevelGenerator.llv.windowtreenumber + 1) - LLevelGenerator.llv.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 3)
            {
                for (int ka = 0; ka < (l3.windowtreenumber + 1) - l3.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 4)
            {
                for (int ka = 0; ka < (l4.windowtreenumber + 1) - l4.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 5)
            {
                for (int ka = 0; ka < (l5.windowtreenumber + 1) - l5.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 6)
            {
                for (int ka = 0; ka < (l6.windowtreenumber + 1) - l6.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 7)
            {
                for (int ka = 0; ka < (l7.windowtreenumber + 1) - l7.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 8)
            {
                for (int ka = 0; ka < (l8.windowtreenumber + 1) - l8.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 9)
            {
                for (int ka = 0; ka < (l9.windowtreenumber + 1) - l9.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 10)
            {
                for (int ka = 0; ka < (l10.windowtreenumber + 1) - l10.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 11)
            {
                for (int ka = 0; ka < (l11.windowtreenumber + 1) - l11.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 12)
            {
                for (int ka = 0; ka < (l12.windowtreenumber + 1) - l12.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 13)
            {
                for (int ka = 0; ka < (l13.windowtreenumber + 1) - l13.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 14)
            {
                for (int ka = 0; ka < (l14.windowtreenumber + 1) - l14.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 15)
            {
                for (int ka = 0; ka < (l15.windowtreenumber + 1) - l15.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 16)
            {
                for (int ka = 0; ka < (l16.windowtreenumber + 1) - l16.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 17)
            {
                for (int ka = 0; ka < (l17.windowtreenumber + 1) - l17.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 18)
            {
                for (int ka = 0; ka < (l18.windowtreenumber + 1) - l18.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 19)
            {
                for (int ka = 0; ka < (l19.windowtreenumber + 1) - l19.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 20)
            {
                for (int ka = 0; ka < (l20.windowtreenumber + 1) - l20.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 21)
            {
                for (int ka = 0; ka < (l21.windowtreenumber + 1) - l21.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 22)
            {
                for (int ka = 0; ka < (l22.windowtreenumber + 1) - l22.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 23)
            {
                for (int ka = 0; ka < (l23.windowtreenumber + 1) - l23.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 24)
            {
                for (int ka = 0; ka < (l24.windowtreenumber + 1) - l24.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 25)
            {
                for (int ka = 0; ka < (l25.windowtreenumber + 1) - l25.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 26)
            {
                for (int ka = 0; ka < (l26.windowtreenumber + 1) - l26.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 27)
            {
                for (int ka = 0; ka < (l27.windowtreenumber + 1) - l27.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 28)
            {
                for (int ka = 0; ka < (l28.windowtreenumber + 1) - l28.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 29)
            {
                for (int ka = 0; ka < (l29.windowtreenumber + 1) - l29.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 30)
            {
                for (int ka = 0; ka < (l30.windowtreenumber + 1) - l30.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 31)
            {
                for (int ka = 0; ka < (l31.windowtreenumber + 1) - l31.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 32)
            {
                for (int ka = 0; ka < (l32.windowtreenumber + 1) - l32.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 33)
            {
                for (int ka = 0; ka < (l33.windowtreenumber + 1) - l33.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 34)
            {
                for (int ka = 0; ka < (l34.windowtreenumber + 1) - l34.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 35)
            {
                for (int ka = 0; ka < (l35.windowtreenumber + 1) - l35.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 36)
            {
                for (int ka = 0; ka < (l36.windowtreenumber + 1) - l36.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 37)
            {
                for (int ka = 0; ka < (l37.windowtreenumber + 1) - l37.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 38)
            {
                for (int ka = 0; ka < (l38.windowtreenumber + 1) - l38.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 39)
            {
                for (int ka = 0; ka < (l39.windowtreenumber + 1) - l39.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 40)
            {
                for (int ka = 0; ka < (l40.windowtreenumber + 1) - l40.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 41)
            {
                for (int ka = 0; ka < (l41.windowtreenumber + 1) - l41.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 42)
            {
                for (int ka = 0; ka < (l42.windowtreenumber + 1) - l42.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 43)
            {
                for (int ka = 0; ka < (l43.windowtreenumber + 1) - l43.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 44)
            {
                for (int ka = 0; ka < (l44.windowtreenumber + 1) - l44.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 45)
            {
                for (int ka = 0; ka < (l45.windowtreenumber + 1) - l45.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 46)
            {
                for (int ka = 0; ka < (l46.windowtreenumber + 1) - l46.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 47)
            {
                for (int ka = 0; ka < (l47.windowtreenumber + 1) - l47.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 48)
            {
                for (int ka = 0; ka < (l48.windowtreenumber + 1) - l48.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 49)
            {
                for (int ka = 0; ka < (l49.windowtreenumber + 1) - l49.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 50)
            {
                for (int ka = 0; ka < (l50.windowtreenumber + 1) - l50.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            else if (currentlevel == 51)
            {
                for (int ka = 0; ka < (l51.windowtreenumber + 1) - l51.enemysayac; ka++)
                {
                    MeshRenderer a = GameObject.FindGameObjectsWithTag("cylinder")[ka].GetComponent<MeshRenderer>();
                    if (a != null)
                    {
                        a.sharedMaterial = materials[1];
                    }
                }
            }
            #endregion



            for (int la = 0; la < branc; la++)
            {
                MeshRenderer ab = GameObject.FindGameObjectsWithTag("branch")[la].GetComponent<MeshRenderer>();
                if (ab != null)
                {
                    ab.sharedMaterial = materials[1];
                }
            }
        }

        if (bug)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }





}