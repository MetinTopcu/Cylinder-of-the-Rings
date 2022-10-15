
using UnityEngine;


public class Point : MonoBehaviour
{
    private Puan puanScripti;
    GoldNumber altin;

    [SerializeField]
    private Vector3 axis = new Vector3(0, 0, 0);

    [SerializeField]
    private LayerMask player_layer;

    [SerializeField]
    private Color collectable_color, nonCollectable_color;

    [SerializeField]
    private Material realGold, fakeGold;

    [SerializeField]
    private AudioClip pickup_sound;

    private PlayerManager pm;

    public static Point pt;

    private GameObject player;

    UIManager uimanager;
    MeshRenderer pointmesh;

    private void Awake()
    {
        pointmesh = GetComponent<MeshRenderer>();
        puanScripti = GameObject.FindObjectOfType<Puan>().GetComponent<Puan>();
        altin = GameObject.Find("_Scripts").GetComponent<GoldNumber>();
        uimanager = GameObject.Find("UIManager").GetComponent<UIManager>();
        pt = this;

        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (GameManager.gm.oyundevam)
        {
            if (PlayerManager.pm.can_collectable)
            {
                //Color and rotation speed
                axis.y = 270;
                pointmesh.material = fakeGold;
                transform.Rotate(axis * Time.deltaTime);
                //Collect Point
                bool touchingToPlayer = Physics.CheckSphere(transform.position, 1.3f, player_layer);
                if (touchingToPlayer && PlayerManager.pm.can_collectable)
                {
                    if (GameManager.gm.pointsayac == 0)
                    {
                        GameManager.gm.a.x = transform.position.x;
                        GameManager.gm.a.y = transform.position.y;
                        GameManager.gm.a.z = transform.position.z;
                    }
                    else if (GameManager.gm.pointsayac == 1)
                    {
                        GameManager.gm.b.x = transform.position.x;
                        GameManager.gm.b.y = transform.position.y;
                        GameManager.gm.b.z = transform.position.z;
                    }
                    else if (GameManager.gm.pointsayac == 2)
                    {
                        GameManager.gm.c.x = transform.position.x;
                        GameManager.gm.c.y = transform.position.y;
                        GameManager.gm.c.z = transform.position.z;
                    }
                    else if (GameManager.gm.pointsayac == 3)
                    {
                        GameManager.gm.d.x = transform.position.x;
                        GameManager.gm.d.y = transform.position.y;
                        GameManager.gm.d.z = transform.position.z;
                    }
                    else if (GameManager.gm.pointsayac == 4)
                    {
                        GameManager.gm.e.x = transform.position.x;
                        GameManager.gm.e.y = transform.position.y;
                        GameManager.gm.e.z = transform.position.z;
                    }
                    else if (GameManager.gm.pointsayac == 5)
                    {
                        GameManager.gm.f.x = transform.position.x;
                        GameManager.gm.f.y = transform.position.y;
                        GameManager.gm.f.z = transform.position.z;
                    }
                    else if (GameManager.gm.pointsayac == 6)
                    {
                        GameManager.gm.g.x = transform.position.x;
                        GameManager.gm.g.y = transform.position.y;
                        GameManager.gm.g.z = transform.position.z;
                    }
                    else if (GameManager.gm.pointsayac == 7)
                    {
                        GameManager.gm.h.x = transform.position.x;
                        GameManager.gm.h.y = transform.position.y;
                        GameManager.gm.h.z = transform.position.z;
                    }
                    else if (GameManager.gm.pointsayac == 8)
                    {
                        GameManager.gm.i.x = transform.position.x;
                        GameManager.gm.i.y = transform.position.y;
                        GameManager.gm.i.z = transform.position.z;
                    }
                    else if (GameManager.gm.pointsayac == 9)
                    {
                        GameManager.gm.j.x = transform.position.x;
                        GameManager.gm.j.y = transform.position.y;
                        GameManager.gm.j.z = transform.position.z;
                    }
                    else if (GameManager.gm.pointsayac == 10)
                    {
                        GameManager.gm.k.x = transform.position.x;
                        GameManager.gm.k.y = transform.position.y;
                        GameManager.gm.k.z = transform.position.z;
                    }
                    else if (GameManager.gm.pointsayac == 11)
                    {
                        GameManager.gm.l.x = transform.position.x;
                        GameManager.gm.l.y = transform.position.y;
                        GameManager.gm.l.z = transform.position.z;
                    }
                    else if (GameManager.gm.pointsayac == 12)
                    {
                        GameManager.gm.m.x = transform.position.x;
                        GameManager.gm.m.y = transform.position.y;
                        GameManager.gm.m.z = transform.position.z;
                    }
                    puanScripti.PuanArtir();
                    Camera.main.GetComponent<AudioSource>().PlayOneShot(pickup_sound, 0.5f);
                    GameManager.gm.pointsayac++;
                    Destroy(this.gameObject);
                }
            }
        }
    }

}
