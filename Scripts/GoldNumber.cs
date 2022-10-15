using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldNumber : MonoBehaviour
{
    public ObjeHavuzu havuz;
    public int cylindernumber;

    public static GoldNumber goldn;
    void Start()
    {
        goldn = this;
        cylindernumber = PlayerPrefs.GetInt("getCylinders");
        switch (cylindernumber)
        {
            case 0:
                havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[6]);
                break;
            case 1:
                havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[8]);
                break;
            case 2:
                havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[2]);
                break;
            case 3:
                havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[3]);
                break;
            case 4:
                havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[4]);
                break;
            case 5:
                havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[5]);
                break;
            case 6:
                havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[0]);
                break;
            case 7:
                havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[7]);
                break;
            case 8:
                havuz = new ObjeHavuzu(PlayerManager.pm.particle_effect[1]);
                break;

            default:
                break;
        }
    }

    public IEnumerator SurekliObjeOlusturVeYokEt()
    {

        GameObject obje = havuz.HavuzdanObjeCek();
        obje.transform.position = PlayerManager.pm.transform.position + new Vector3(0f, 0f, 1f);
        //obje.transform.rotation = prefab.transform.rotation;

        //GameObject obje2 = havuz2.HavuzdanObjeCek();
        //obje2.transform.position = konum;

        yield return new WaitForSeconds(1f);

        havuz.HavuzaObjeEkle(obje);
        //havuz2.HavuzaObjeEkle(obje2);

    }

}
