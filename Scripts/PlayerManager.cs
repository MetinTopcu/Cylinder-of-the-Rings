using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Puan puanScripti;
    GoldNumber altin;

    public bool winOrlose;

    private const float size_scaler = 0.2f;
    private const float checker_radius = 0.15f;
    private const float offset = 0.05f;

    public GameObject konum;

    public List<GameObject> particle_effect;

    Point point;

    [SerializeField]
    private Vector3 default_size = new Vector3(1, 1, 1);

    [SerializeField]
    private LayerMask cylinder_layer;

    [SerializeField]
    private AudioClip click_sound,death_sound;


    [HideInInspector]
    public bool can_collectable = false;

    public float health = 10.0f;
    public static PlayerManager pm;


    private AudioSource camera;

    private CameraController camcontrol;

    //public GameObject prefab;
    //private GameObject prefab2;
    private ObjeHavuzu havuz2;

    public int cylindernumber;

    private Transform cyl;
    private float cyl_radius;

    public AudioSource konumclickaudio;

    public int particlenumber;
    public int playernumber;

    public int interstitial = 0;

    #region Unity
    void Start()
    {
        particlenumber = PlayerPrefs.GetInt("getCylinders");
        playernumber = PlayerPrefs.GetInt("getPlayers");

        cylindernumber = PlayerPrefs.GetInt("getCylinders");
      


        pm = this;
        puanScripti = GameObject.FindObjectOfType<Puan>().GetComponent<Puan>();
        altin = GameObject.Find("_Scripts").GetComponent<GoldNumber>();
        point = GameObject.Find("_Scripts").GetComponent<Point>();
        camera = Camera.main.GetComponent<AudioSource>();
        camcontrol = Camera.main.GetComponent<CameraController>();
        konumclickaudio = GameObject.FindGameObjectWithTag("mytrigger").GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (GameManager.gm.oyundevam && GameManager.gm.startgame)
        {
            Camera.main.transform.Translate(Vector3.forward * CameraController.camcont.speed * Time.deltaTime, Space.World);
        }



        //Define cylinder 
        if (GameManager.gm.oyundevam == true)
        {
            playernumber = PlayerPrefs.GetInt("getPlayers");
            switch (playernumber)
            {
                case 0:
                    cyl = Physics.OverlapSphere(transform.position, checker_radius, cylinder_layer)[0].transform;
                    cyl_radius = cyl.localScale.x * size_scaler;
                    ChangeRingRadius(cyl_radius);
                    //Check for Player Death
                    if (health <= 0)
                    {
                        Death();
                    }

                    if (cyl_radius > transform.localScale.y)
                    {
                        Death();
                    }

                    if (cyl.CompareTag("Enemy"))
                    {
                        if (cyl_radius + offset > transform.localScale.y)
                        {
                            Death();
                        }
                    }
                    //Check can_collect
                    if (cyl_radius + offset > transform.localScale.y)
                    {
                        can_collectable = true;
                    }
                    else
                    {
                        can_collectable = false;
                    }
                    break;
                case 1:
                    cyl = Physics.OverlapSphere(transform.position, 0.05f, cylinder_layer)[0].transform;
                    cyl_radius = cyl.localScale.x * 0.06f;
                    ChangeRingRadius(cyl_radius);
                    //Check for Player Death
                    if (health <= 0)
                    {
                        Death();
                    }

                    if (cyl_radius > transform.localScale.x)
                    {
                        Death();
                    }

                    if (cyl.CompareTag("Enemy"))
                    {
                        if (cyl_radius + 0.03f > transform.localScale.x)
                        {
                            Death();
                        }
                    }

                    //Check can_collect
                    if (cyl_radius + 0.03f > transform.localScale.x)
                    {
                        can_collectable = true;
                    }
                    else
                    {
                        can_collectable = false;
                    }
                    break;
                case 2:
                    cyl = Physics.OverlapSphere(transform.position, 0.05f, cylinder_layer)[0].transform;
                    cyl_radius = cyl.localScale.x * 0.7f;
                    ChangeRingRadius(cyl_radius);
                    //Check for Player Death
                    if (health <= 0)
                    {
                        Death();
                    }

                    if (cyl_radius > transform.localScale.x)
                    {
                        Death();
                    }

                    if (cyl.CompareTag("Enemy"))
                    {
                        if (cyl_radius + 0.03f > transform.localScale.x)
                        {
                            Death();
                        }
                    }

                    //Check can_collect
                    if (cyl_radius + 0.03f > transform.localScale.x)
                    {
                        can_collectable = true;
                    }
                    else
                    {
                        can_collectable = false;
                    }
                    break;
                case 3:
                    cyl = Physics.OverlapSphere(transform.position, 0.1f, cylinder_layer)[0].transform;
                    cyl_radius = cyl.localScale.x * 0.0345f;
                    ChangeRingRadius(cyl_radius);
                    //Check for Player Death
                    if (health <= 0)
                    {
                        Death();
                    }

                    if (cyl_radius > transform.localScale.x)
                    {
                        Death();
                    }

                    if (cyl.CompareTag("Enemy"))
                    {
                        if (cyl_radius + 0.02f > transform.localScale.x)
                        {
                            Death();
                        }
                    }

                    //Check can_collect
                    if (cyl_radius + 0.02f > transform.localScale.x)
                    {
                        can_collectable = true;
                    }
                    else
                    {
                        can_collectable = false;
                    }
                    break;
                case 4:
                    cyl = Physics.OverlapSphere(transform.position, 0.35f, cylinder_layer)[0].transform;
                    cyl_radius = cyl.localScale.x * 0.135f;
                    ChangeRingRadius(cyl_radius);
                    //Check for Player Death
                    if (health <= 0)
                    {
                        Death();
                    }

                    if (cyl_radius > transform.localScale.x)
                    {
                        Death();
                    }

                    if (cyl.CompareTag("Enemy"))
                    {
                        if (cyl_radius + 0.02f > transform.localScale.x)
                        {
                            Death();
                        }
                    }

                    //Check can_collect
                    if (cyl_radius + 0.02f > transform.localScale.x)
                    {
                        can_collectable = true;
                    }
                    else
                    {
                        can_collectable = false;
                    }
                    break;
                case 5:
                    cyl = Physics.OverlapSphere(transform.position, 0.15f, cylinder_layer)[0].transform;
                    cyl_radius = cyl.localScale.x * 0.53f;
                    ChangeRingRadius(cyl_radius);
                    //Check for Player Death
                    if (health <= 0)
                    {
                        Death();
                    }

                    if (cyl_radius > transform.localScale.x)
                    {
                        Death();
                    }

                    if (cyl.CompareTag("Enemy"))
                    {
                        if (cyl_radius + 0.02f > transform.localScale.x)
                        {
                            Death();
                        }
                    }

                    //Check can_collect
                    if (cyl_radius + 0.2f > transform.localScale.x)
                    {
                        can_collectable = true;
                    }
                    else
                    {
                        can_collectable = false;
                    }
                    break;
                case 6:
                    cyl = Physics.OverlapSphere(transform.position, 0.1f, cylinder_layer)[0].transform;
                    cyl_radius = cyl.localScale.x * 0.55f;
                    ChangeRingRadius(cyl_radius);
                    //Check for Player Death
                    if (health <= 0)
                    {
                        Death();
                    }

                    if (cyl_radius > transform.localScale.x)
                    {
                        Death();
                    }

                    if (cyl.CompareTag("Enemy"))
                    {
                        if (cyl_radius + 0.02f > transform.localScale.x)
                        {
                            Death();
                        }
                    }

                    //Check can_collect
                    if (cyl_radius + 0.02f > transform.localScale.x)
                    {
                        can_collectable = true;
                    }
                    else
                    {
                        can_collectable = false;
                    }
                    break;
                case 7:
                    cyl = Physics.OverlapSphere(transform.position, 0.1f, cylinder_layer)[0].transform;
                    cyl_radius = cyl.localScale.x * 0.04f;
                    ChangeRingRadius(cyl_radius);
                    //Check for Player Death
                    if (health <= 0)
                    {
                        Death();
                    }

                    if (cyl_radius > transform.localScale.x)
                    {
                        Death();
                    }

                    if (cyl.CompareTag("Enemy"))
                    {
                        if (cyl_radius + 0.02f > transform.localScale.x)
                        {
                            Death();
                        }
                    }

                    //Check can_collect
                    if (cyl_radius + 0.02f > transform.localScale.x)
                    {
                        can_collectable = true;
                    }
                    else
                    {
                        can_collectable = false;
                    }
                    break;
                case 8:
                    cyl = Physics.OverlapSphere(transform.position, 0.3f, cylinder_layer)[0].transform;
                    cyl_radius = cyl.localScale.x * 0.06f;
                    ChangeRingRadius(cyl_radius);
                    //Check for Player Death
                    if (health <= 0)
                    {
                        Death();
                    }

                    if (cyl_radius > transform.localScale.x)
                    {
                        Death();
                    }

                    if (cyl.CompareTag("Enemy"))
                    {
                        if (cyl_radius + 0.015f > transform.localScale.x)
                        {
                            Death();
                        }
                    }

                    //Check can_collect
                    if (cyl_radius + 0.015f > transform.localScale.x)
                    {
                        can_collectable = true;
                    }
                    else
                    {
                        can_collectable = false;
                    }
                    break;
                default:
                    break;
            }
        }
       

        HealthCounter();
    }
    #endregion

    #region Functions
    public void Death()
    {
        konumclickaudio.mute = true;
        winOrlose = false;
        GameManager.gm.oyundevam = false;
        GameManager.gm.startgame = false;

        //Play Death Sound Effect
        camera.PlayOneShot(death_sound,0.5f);

        finishgame();
        //Save High score
        /*
        if (altin.distance > PlayerPrefs.GetFloat("Highscore2"))
        {
            PlayerPrefs.SetFloat("Highscore2", altin.distance);
        }
        UIManager.ui_m.SetHighScoreText();
        */

        //Open UI Manager
        UIManager.ui_m.OpenGameOverUI();

        //Destroy player GameObject
        gameObject.transform.position = new Vector3(0, -7.749999f, -7.5f);
        gameObject.transform.parent = Camera.main.transform;
        //Destroy(this.gameObject);

    }

    public void finishgame()
    {
        konumclickaudio.mute = true;
        if (GameManager.gm.interstitial == 3)
        {
            Admob.adm.OpenInterstitial();
        }
        //Stop Camera Controller
        UIManager.ui_m.CloseGamePanel();
        //Player Alive Boolean
        GameManager.gm.gamePlay = false;

        int a = puanScripti.PuaniAl();
        PlayerPrefs.SetInt("puan", a);
        //puanScripti.text.text = PlayerPrefs.GetInt("puan") + "";
        puanScripti.text.SetText(PlayerPrefs.GetInt("puan") + "");
        float b = puanScripti.WoodCome();
        PlayerPrefs.SetFloat("wood", b);
        //puanScripti.woodtext.text = PlayerPrefs.GetFloat("wood").ToString("f1");
        puanScripti.woodtext.SetText(PlayerPrefs.GetFloat("wood").ToString("f0"));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            winOrlose = true;
            GameManager.gm.oyundevam = false;
            GameManager.gm.startgame = false;
            UIManager.ui_m.Openlevelcompleted();
            finishgame();
        }
    }

    private void ChangeRingRadius(float cyl_radius)
    {
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            //Play sound effect
            if (touch.phase == TouchPhase.Began && GameManager.gm.oyundevam)
            {
            }

            // when touched to screen 
            if (touch.phase == TouchPhase.Stationary && GameManager.gm.oyundevam)
            {

                Vector3 target_vector;
                playernumber = PlayerPrefs.GetInt("getPlayers");
                switch (playernumber)
                {
                    case 0:
                        target_vector = new Vector3(default_size.x, cyl_radius, cyl_radius);
                        transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                        break;
                    case 1:
                        target_vector = new Vector3(cyl_radius, 0.1f, cyl_radius);
                        transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                        break;
                    case 2:
                        target_vector = new Vector3(cyl_radius, 1.5f, cyl_radius);
                        transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                        break;
                    case 3:
                        target_vector = new Vector3(cyl_radius, 0.04f, cyl_radius);
                        transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                        break;
                    case 4:
                        target_vector = new Vector3(cyl_radius, cyl_radius, 0.4f);
                        transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                        break;
                    case 5:
                        target_vector = new Vector3(cyl_radius, cyl_radius, 1f);
                        transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                        break;
                    case 6:
                        target_vector = new Vector3(cyl_radius, cyl_radius, 2f);
                        transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                        break;
                    case 7:
                        target_vector = new Vector3(cyl_radius, 0.06f, cyl_radius);
                        transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                        break;
                    case 8:
                        target_vector = new Vector3(cyl_radius, cyl_radius, 0.2f);
                        transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                        break;
                    default:
                        break;
                }
                if (can_collectable)
                {
                    //camera.PlayOneShot(click_sound, 1f);
                    konumclickaudio.mute = false;
                    puanScripti.WoodPlus();
                    particlenumber = PlayerPrefs.GetInt("getCylinders");
                    switch (particlenumber)
                    {
                        case 0:
                            StartCoroutine(GoldNumber.goldn.SurekliObjeOlusturVeYokEt());
                            //Instantiate(particle_effect[0], transform.position + new Vector3(0f, 0f, 1f), particle_effect[0].transform.rotation);
                            break;
                        case 1:
                            StartCoroutine(GoldNumber.goldn.SurekliObjeOlusturVeYokEt());
                            //Instantiate(particle_effect[1], transform.position + new Vector3(0f, 0f, 1f), particle_effect[1].transform.rotation);
                            break;
                        case 2:
                            StartCoroutine(GoldNumber.goldn.SurekliObjeOlusturVeYokEt());
                            //Instantiate(particle_effect[2], transform.position + new Vector3(0f, 0f, 1f), particle_effect[2].transform.rotation);
                            break;
                        case 3:
                            StartCoroutine(GoldNumber.goldn.SurekliObjeOlusturVeYokEt());
                            //Instantiate(particle_effect[3], transform.position + new Vector3(0f, 0f, 1f), particle_effect[3].transform.rotation);
                            break;
                        case 4:
                            StartCoroutine(GoldNumber.goldn.SurekliObjeOlusturVeYokEt());
                            //Instantiate(particle_effect[4], transform.position + new Vector3(0f, 0f, 1f), particle_effect[4].transform.rotation);
                            break;
                        case 5:
                            StartCoroutine(GoldNumber.goldn.SurekliObjeOlusturVeYokEt());
                            //Instantiate(particle_effect[5], transform.position + new Vector3(0f, 0f, 1f), particle_effect[5].transform.rotation);
                            break;
                        case 6:
                            StartCoroutine(GoldNumber.goldn.SurekliObjeOlusturVeYokEt());
                            //Instantiate(particle_effect[6], transform.position + new Vector3(0f, 0f, 1f), particle_effect[6].transform.rotation);
                            break;
                        case 7:
                            StartCoroutine(GoldNumber.goldn.SurekliObjeOlusturVeYokEt());
                            //Instantiate(particle_effect[7], transform.position + new Vector3(0f, 0f, 1f), particle_effect[7].transform.rotation);
                            break;
                        case 8:
                            StartCoroutine(GoldNumber.goldn.SurekliObjeOlusturVeYokEt());
                            //Instantiate(particle_effect[8], transform.position + new Vector3(0f, 0f, 1f), particle_effect[8].transform.rotation);
                            break;
                        default:
                            break;
                    }
                    if (health <= 4f && health >= 2f)
                    {
                        IncreaseHealth(0.1f);
                    }
                    else if (health < 2f)
                    {
                        IncreaseHealth(0.18f);
                    }
                    else
                    {
                        IncreaseHealth(0.05f);
                    }

                }

            }
        }
        else
        {
            konumclickaudio.mute = true;
            //transform.localScale = Vector3.Slerp(transform.localScale, default_size, 0.125f);
            playernumber = PlayerPrefs.GetInt("getPlayers");
            switch (playernumber)
            {
                case 0:
                    transform.localScale = Vector3.Slerp(transform.localScale, default_size, 0.25f);
                    break;
                case 1:
                    transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(0.3f, 0.1f, 0.3f), 0.25f);
                    break;
                case 2:
                    transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(3f, 1.5f, 3f), 0.25f);
                    break;
                case 3:
                    transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(0.168f, 0.04f, 0.168f), 0.25f);
                    break;
                case 4:
                    transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(0.7f, 0.7f, 0.4f), 0.25f);
                    break;
                case 5:
                    transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(2.5f, 2.5f, 1f), 0.25f);
                    break;
                case 6:
                    transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(2.5f, 2.5f, 2f), 0.25f);
                    break;
                case 7:
                    transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(0.2f, 0.06f, 0.2f), 0.25f);
                    break;
                case 8:
                    transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(0.3f, 0.3f, 0.2f), 0.25f);
                    break;
                default:
                    break;
            }
        }
        
        /*
        if (Input.GetMouseButtonDown(0))
        {
            Camera.main.GetComponent<AudioSource>().PlayOneShot(click_sound, 0.5f);
        }
        if (Input.GetMouseButton(0) && oyundevam)
        {
            Vector3 target_vector;
            int playernumber = PlayerPrefs.GetInt("getPlayer");
            switch (playernumber)
            {
                case 0:
                    target_vector = new Vector3(default_size.x, cyl_radius, cyl_radius);
                    transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                    break;
                case 1:
                    target_vector = new Vector3(cyl_radius, 0.1f, cyl_radius);
                    transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                    break;
                case 2:
                    target_vector = new Vector3(cyl_radius, 1.5f, cyl_radius);
                    transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                    break;
                case 3:
                    target_vector = new Vector3(cyl_radius, 0.04f, cyl_radius);
                    transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                    break;
                case 4:
                    target_vector = new Vector3(cyl_radius, cyl_radius, 0.4f);
                    transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                    break;
                case 5:
                    target_vector = new Vector3(cyl_radius, cyl_radius, 1f);
                    transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                    break;
                case 6:
                    target_vector = new Vector3(cyl_radius, cyl_radius, 2f);
                    transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                    break;
                case 7:
                    target_vector = new Vector3(cyl_radius, 0.06f, cyl_radius);
                    transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                    break;
                case 8:
                    target_vector = new Vector3(cyl_radius, cyl_radius, 0.2f);
                    transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.25f);
                    break;
                default:
                    break;
            }
            if (can_collectable)
            {
                altin.WoodAdd();
                puanScripti.WoodPlus();
                int particlenumber = PlayerPrefs.GetInt("getCylinder");
                switch (particlenumber)
                {
                    case 0:
                        Instantiate(particle_effect[0], transform.position + new Vector3(0f, 0f, 1f), particle_effect[0].transform.rotation);
                        break;
                    case 1:
                        Instantiate(particle_effect[1], transform.position + new Vector3(0f, 0f, 1f), particle_effect[1].transform.rotation);
                        break;
                    case 2:
                        Instantiate(particle_effect[2], transform.position + new Vector3(0f, 0f, 1f), particle_effect[2].transform.rotation);
                        break;
                    case 3:
                        Instantiate(particle_effect[3], transform.position + new Vector3(0f, 0f, 1f), particle_effect[3].transform.rotation);
                        break;
                    case 4:
                        Instantiate(particle_effect[4], transform.position + new Vector3(0f, 0f, 1f), particle_effect[4].transform.rotation);
                        break;
                    case 5:
                        Instantiate(particle_effect[5], transform.position + new Vector3(0f, 0f, 1f), particle_effect[5].transform.rotation);
                        break;
                    case 6:
                        Instantiate(particle_effect[6], transform.position + new Vector3(0f, 0f, 1f), particle_effect[6].transform.rotation);
                        break;
                    case 7:
                        Instantiate(particle_effect[7], transform.position + new Vector3(0f, 0f, 1f), particle_effect[7].transform.rotation);
                        break;
                    case 8:
                        Instantiate(particle_effect[8], transform.position + new Vector3(0f, 0f, 1f), particle_effect[8].transform.rotation);
                        break;
                    default:
                        break;
                }
                if (health <= 4f && health >= 2f )
                {
                    IncreaseHealth(0.1f);
                }
                else if (health < 2f)
                {
                    IncreaseHealth(0.18f);
                }
                else
                {
                    IncreaseHealth(0.05f);
                }
                
            }
        }
        
        else
        {
            int playernumber = PlayerPrefs.GetInt("getPlayer");
            switch (playernumber)
            {
                case 0:
                    transform.localScale = Vector3.Slerp(transform.localScale, default_size, 0.25f);
                    break;
                case 1:
                    transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(0.3f, 0.1f, 0.3f), 0.25f);
                    break;
                case 2:
                    transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(3f, 1.5f, 3f), 0.25f);
                    break;
                case 3:
                    transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(0.168f, 0.04f, 0.168f), 0.25f);
                    break;
                case 4:
                    transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(0.7f, 0.7f, 0.4f), 0.25f);
                    break;
                case 5:
                    transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(2.5f, 2.5f, 1f), 0.25f);
                    break;
                case 6:
                    transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(2.5f, 2.5f, 2f), 0.25f);
                    break;
                case 7:
                    transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(0.2f, 0.06f, 0.2f), 0.25f);
                    break;
                case 8:
                    transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(0.3f, 0.3f, 0.2f), 0.25f);
                    break;
                default:
                    break;
            }
        }
        
        */
    }

    private void HealthCounter()
    {
        health = Mathf.Clamp(health,-1, 10.0f);
        if (health >= 0 && GameManager.gm.oyundevam)
        {
            health -= Time.deltaTime;
            UIManager.ui_m.SetPlayerHealth(health);
        }
    }

    public void IncreaseHealth(float value)
    {
        health += value;
    }
    #endregion
}
