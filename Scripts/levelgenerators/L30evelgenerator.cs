using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L30evelgenerator : MonoBehaviour
{
    #region SerializeFields
    [Header("Cylinder Attributes")]
    [Tooltip("Default cylinder prefab for instantiate")]
    [SerializeField]
    private GameObject cylinder;

    [SerializeField]
    private GameObject tree;

    [SerializeField]
    private float minRadius, maxRadius;

    [Header("Enemy Cylinder Attributes")]
    [SerializeField]
    private Material enemy_cylinder;

    public int odunsayisi = 0;
    public int yokedilenodun = 0;

    public int windowtreenumber;

    #endregion

    private GameObject previous_cylinder;

    public float andgamedistance;

    public int enemynumber = 0;

    public int enemysayac;

    public GameObject level8;

    #region functions

    private float FindRadius(float minR, float maxR)
    {

        float radius = Random.Range(minR, maxR);

        if (previous_cylinder != null)
        {
            while (Mathf.Abs(radius - previous_cylinder.transform.localScale.x) < 0.6f)
            {
                radius = Random.Range(minR, maxR);
            }
        }

        return radius;
    }

    public void SpawnCylinder()
    {
        // find a random radius and height
        odunsayisi++;

        float radius = FindRadius(minRadius, maxRadius);
        float height = Random.Range(3.5f, 5f);

        //Apply radius and height to prefab
        cylinder.transform.localScale = new Vector3(radius, height, radius);
        //Instantiate cylinder

        //Instantiate First cylinder
        if (previous_cylinder == null)
        {
            previous_cylinder = Instantiate(cylinder, Vector3.zero, Quaternion.identity);
            previous_cylinder.transform.parent = level8.transform;
        }
        //Instantiate All other cylinders
        else
        {
            float spawnPoint = previous_cylinder.transform.position.z + previous_cylinder.transform.localScale.y
                + cylinder.transform.localScale.y;
            previous_cylinder = Instantiate(cylinder, new Vector3(0, 0, spawnPoint), Quaternion.identity);
            previous_cylinder.transform.parent = level8.transform;

            //Create Enemy Cylinders
            if (Random.value < 0.23f && odunsayisi >= 2 && odunsayisi <= windowtreenumber)
            {
                enemysayac++;
                enemynumber = enemynumber + 1;
                previous_cylinder.GetComponent<Renderer>().material = enemy_cylinder;
                previous_cylinder.tag = "Enemy";
            }
        }
        //Rotate
        previous_cylinder.transform.Rotate(90, 0, 0);


        if (odunsayisi == windowtreenumber + 1)
        {
            andgamedistance = previous_cylinder.transform.position.z + previous_cylinder.transform.localScale.y;
            tree = Instantiate(tree, new Vector3(0, 0, andgamedistance), Quaternion.Euler(180, 0, 0));
            tree.transform.parent = level8.transform;
        }

    }
    #endregion
}
