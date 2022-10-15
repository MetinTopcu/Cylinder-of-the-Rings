
using GoogleMobileAds.Api;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public TMP_Text niakaitext;
    public TMP_Text gamestext;
    public Image joystick;

    private float alpha = 5;
    public GameObject loadingscreen;

    public static MainMenu mame;

    /*
    void Start()
    {

        mame = this;
        //Input.simulateMouseWithTouches = false;
        //Screen.SetResolution(Screen.currentResolution.width / 1, Screen.currentResolution.height / 1, true);
        //niakaitext.CrossFadeAlpha(0f, 2f, true);
        //gamestext.CrossFadeAlpha(0f, 2f, true);
        //joystick.CrossFadeAlpha(0f, 2f, true);

        niakaitext.CrossFadeAlpha(0f, 0.001f, false);
        gamestext.CrossFadeAlpha(0f, 0.001f, false);
        joystick.CrossFadeAlpha(0f, 0.001f, false);

    }
    */
    /*

    void Update()
    {
        alpha -= Time.deltaTime;
        if (alpha <= 4.9f && alpha >= 4.8f)
        {
            niakaitext.CrossFadeAlpha(2f, 10f, true);
            gamestext.CrossFadeAlpha(2f, 10f, true);
            joystick.CrossFadeAlpha(2f, 10f, true);
        }
        if (alpha <= 3.7f && alpha >= 3.6f)
        {
            niakaitext.CrossFadeAlpha(0f, 1f, true);
            gamestext.CrossFadeAlpha(0f, 1f, true);
            joystick.CrossFadeAlpha(0f, 1f, true);
        }

        if (alpha <= 2.5f && alpha >= 2.4f)
        {
            SceneManager.LoadScene(1);
        }
    }
    */
}
