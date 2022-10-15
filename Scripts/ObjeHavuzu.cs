
using System.Collections.Generic;
using UnityEngine;

public class ObjeHavuzu : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    public Stack<GameObject> objeHavuzu = new Stack<GameObject>();

    public static ObjeHavuzu objH;

    private void Start()
    {
        objH = this;
    }


    public ObjeHavuzu(GameObject prefab)
    {
        this.prefab = prefab;
    }

    public void HavuzuDoldur(int miktar)
    {

        for (int i = 0; i < miktar; i++)
        {
            GameObject obje = Object.Instantiate(prefab);
            HavuzaObjeEkle(obje);
        }
    }

    public GameObject HavuzdanObjeCek()
    {
        if (objeHavuzu.Count > 0)
        {
            GameObject obje = objeHavuzu.Pop();
            obje.gameObject.SetActive(true);

            return obje;
        }

        return Object.Instantiate(prefab);
    }

    public void HavuzaObjeEkle(GameObject obje)
    {
        obje.gameObject.SetActive(false);
        objeHavuzu.Push(obje);
    }
}
