using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScripts : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1;

    private float _endPox;

    [SerializeField]
    private bool ekrandami = true;

    private CameraController cc;

    void Start()
    {
        cc = GameObject.Find("Main Camera").GetComponent<CameraController>();
    }

    public void StartFloating(float speed, float endPosX)
    {
        _speed = speed;
        _endPox = endPosX;
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 20)
        {
            ekrandami = false;
        }
        if (!ekrandami)
        {
            transform.Translate(new Vector3(1, 0, cc.speed) * Time.deltaTime * _speed);
            if (transform.position.x > _endPox)
            {
                CloudGeneratorScript.cgs.cloudnumber--;
                Destroy(gameObject);
            }
        }
        else
        {
            transform.Translate(Time.deltaTime * _speed,0,0);
        }
       
    }
}
