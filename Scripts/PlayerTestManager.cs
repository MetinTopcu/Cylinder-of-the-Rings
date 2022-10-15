/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestManager : MonoBehaviour
{
 public float size_scalel = 0.2f;

 [SerializeField]
 private Vector3 default_size = new Vector3(1, 1, 1);

 [SerializeField]
 private LayerMask cylinder_layer;


 void Update()
 {
     Transform cyl = Physics.OverlapSphere(transform.position, 0.1f, cylinder_layer)[0].transform;
     float cyl_radius = cyl.localScale.x * 0.06f;
     if (Input.GetMouseButton(0))
     {
         Vector3 target_vector = new Vector3(cyl_radius, cyl_radius, 0.2f);
         transform.localScale = Vector3.Slerp(transform.localScale, target_vector, 0.2f);
     }
     else
     {
         transform.localScale = Vector3.Slerp(transform.localScale, new Vector3(0.3f, 0.3f, 0.2f), 0.2f);
     }
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
}
}*/
