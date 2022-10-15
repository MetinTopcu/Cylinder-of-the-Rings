
using UnityEngine;

public class ShopController : MonoBehaviour
{
    public static ShopController sc;
    public GameObject canvasCamera;
    public GameObject canvas;

    public GameObject player, ring1, ring2, ring3, ring4, ring5, ring6, ring7, ring8;
    public GameObject cylinder, skin1, skin2, skin3, skin4, skin5, skin6, skin7, skin8;

    private Puan puanScripti;

    public Camera Camera;
    void Start()
    {
        sc = this;
        puanScripti = GameObject.FindObjectOfType<Puan>().GetComponent<Puan>();
    }
    public void canvasCamera1Open()
    {
        cylinder.SetActive(true);
        skin1.SetActive(true);
        skin2.SetActive(true);
        skin3.SetActive(true);
        skin4.SetActive(true);
        skin5.SetActive(true);
        skin6.SetActive(true);
        skin7.SetActive(true);
        skin8.SetActive(true);
        canvasCamera.SetActive(true);
    }

    public void canvasCamera1Close()
    {
        cylinder.SetActive(false);
        skin1.SetActive(false);
        skin2.SetActive(false);
        skin3.SetActive(false);
        skin4.SetActive(false);
        skin5.SetActive(false);
        skin6.SetActive(false);
        skin7.SetActive(false);
        skin8.SetActive(false);
        canvasCamera.SetActive(false);
    }
    public void canvasCameraOpen()
    {
        player.SetActive(true);
        ring1.SetActive(true);
        ring2.SetActive(true);
        ring3.SetActive(true);
        ring4.SetActive(true);
        ring5.SetActive(true);
        ring6.SetActive(true);
        ring7.SetActive(true);
        ring8.SetActive(true);
        canvasCamera.SetActive(true);
    }

    public void canvasCameraClose()
    {
        player.SetActive(false);
        ring1.SetActive(false);
        ring2.SetActive(false);
        ring3.SetActive(false);
        ring4.SetActive(false);
        ring5.SetActive(false);
        ring6.SetActive(false);
        ring7.SetActive(false);
        ring8.SetActive(false);
        canvasCamera.SetActive(false);
    }

    public void canvasSettings1()
    {
        canvas.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
        //canvas.GetComponent<Canvas>().worldCamera = Camera;
    }
    public void canvasSettings2()
    {
        canvas.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceCamera;
        //canvas.GetComponent<Canvas>().worldCamera = null;
    }
}
