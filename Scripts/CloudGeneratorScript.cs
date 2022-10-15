using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGeneratorScript : MonoBehaviour
{
    public GameObject clouds;

    [SerializeField]
    private GameObject endPoint;

    private Vector3 startPos;

    [SerializeField]
    private LayerMask clouds_layer;

    Collider[] aa = new Collider[1];

    GameObject cloud;

    private Transform cameratra;

    public static CloudGeneratorScript cgs;

    public int cloudnumber;

    private void Start()
    {
        cgs = this;
        cameratra = Camera.main.transform;
        if (GameManager.gm.randomcloud == 0)
        {
            clouds = GameManager.gm.cloud1;
        }
        else if (GameManager.gm.randomcloud == 1)
        {
            clouds = GameManager.gm.cloud2;
        }
        else if (GameManager.gm.randomcloud == 2)
        {
            clouds = GameManager.gm.cloud3;
        }
    }

    private void Update()
    {
        startPos = transform.position;

        int ab = Physics.OverlapSphereNonAlloc(transform.position, 5f, aa,clouds_layer);
        if (ab <= 0)
        {
            SpawnCloud(startPos);
        }
    }


    void SpawnCloud(Vector3 startPos)
    {
        //int randomIndeX = Random.Range(0, clouds.Length);
        //cloud = Instantiate(clouds[randomIndeX]);
        cloud = Instantiate(clouds);
        cloud.transform.parent = cameratra;
        cloud.tag = "sahnecloud";
        cloudnumber++;
        float startY = Random.Range(startPos.y - 1f, startPos.y + 1f);
        cloud.transform.position = new Vector3(startPos.x,startY,startPos.z);

        float scale = Random.Range(0.99f, 1f);
        cloud.transform.localScale = new Vector3(scale, scale,0);

        float speed = Random.Range(0.99f, 1f);
        cloud.GetComponent<CloudScripts>().StartFloating(speed,endPoint.transform.position.x);
    }


}
