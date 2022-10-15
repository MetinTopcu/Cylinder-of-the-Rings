using TMPro;
using UnityEngine;

public class Puan : MonoBehaviour
{
    public TMP_Text distance_Value, wood_value;
    public float wood;
    public TMP_Text woodtext;

    public int puan;
    public TMP_Text text;

    public static Puan pa;
    public void WoodPlus()
    {
        wood = wood + 0.05f;
        wood_value.SetText(wood.ToString("f0"));
        //print("wood : " + wood);
    }

    public float WoodCome()
    {
        //print("WoodCome: " + wood);
        return wood;
    }

    public void buyWood()
    {
        PlayerPrefs.SetFloat("wood", wood);
        //woodtext.text = PlayerPrefs.GetFloat("wood").ToString("f0");
        woodtext.SetText(PlayerPrefs.GetFloat("wood").ToString("f0"));
        wood_value.SetText(PlayerPrefs.GetFloat("wood").ToString("f0"));
    }

    public void PuanArtir()
    {
        puan++;
        distance_Value.SetText(puan + "");
    }
    public int PuaniAl()
    {
        return puan;
    }
    public void satinAl()
    {
        PlayerPrefs.SetInt("puan", puan);
        //text.text = PlayerPrefs.GetInt("puan") + "";
        text.SetText(PlayerPrefs.GetInt("puan") + "");
        distance_Value.SetText(PlayerPrefs.GetInt("puan") + "");
    }
    void Start()
    {
        pa = this;
        puan = PlayerPrefs.GetInt("puan");
        distance_Value.SetText(PlayerPrefs.GetInt("puan")+"");
        wood_value.SetText(PlayerPrefs.GetFloat("wood").ToString("f0"));
        //text.text = PlayerPrefs.GetInt("puan") + "";
        text.SetText(PlayerPrefs.GetInt("puan") + "");
        wood = PlayerPrefs.GetFloat("wood");
        //woodtext.text = PlayerPrefs.GetFloat("wood").ToString("f0");
        woodtext.SetText(PlayerPrefs.GetFloat("wood").ToString("f0"));
        //text.text = "" + PuaniAl();
    }

}
