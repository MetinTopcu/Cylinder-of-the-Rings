
using TMPro;
using UnityEngine;

using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text level_label;

    public Text firslevel_text;
    public Text secondlevel_text;

    public static UIManager ui_m;
    [SerializeField]
    public GameObject gameOver_panel;
    
    [SerializeField]
    private GameObject audio;

    [SerializeField]
    private GameObject audio1;

    [SerializeField]
    private GameObject TapToPlay;

    [SerializeField]
    private GameObject GamePanel;

    [SerializeField]
    private GameObject levelcompleted;


    [SerializeField]
    private RectTransform health_bar;

    [SerializeField]
    private TMP_Text highscore_text;

    private bool audiotrue = false;

    private void Awake()
    {
        //gamestext.color = Color.Lerp(new Color32(65, 180, 250, 255), Color.white, 0.8f);
        //GameManager.gm.currentlevel = PlayerPrefs.GetInt("levelx");
        ui_m = this;
        firslevel_text.text = GameManager.gm.curumlevel + "";
        secondlevel_text.text = (GameManager.gm.curumlevel + 1) + "";
    }
    public void Openlevelcompleted()
    {
        if (levelcompleted != null)
        {
            level_label.text = "Level " + (GameManager.gm.curumlevel + 1) + " COMPLETED!";
            levelcompleted.SetActive(true);
        }
    }
    public void Closelevelcompleted()
    {
        if (levelcompleted != null)
        {
            levelcompleted.SetActive(false);
        }
    }

    public void OpenGamePanel()
    {
        if (GamePanel != null)
        {
            GamePanel.SetActive(true);
        }
    }
    public void CloseGamePanel()
    {
        if (GamePanel != null)
        {
            GamePanel.SetActive(false);
        }
    }
    public void OpenTapToPlay()
    {
        if (TapToPlay != null)
        {
            TapToPlay.SetActive(true);
        }
    }
    public void CloseTapToPlay()
    {
        if (TapToPlay != null)
        {
            TapToPlay.SetActive(false);
        }
    }
    public void OpenAudios()
    {
        if (audio != null)
        {
            if (!audiotrue)
            {
                audio.SetActive(true);
            }
            else
            {
                audio.SetActive(false);
            }

        }

        if (audio1 != null)
        {
            if (!audiotrue)
            {
                audio1.SetActive(true);
                audiotrue = true;
            }
            else
            {
                audio1.SetActive(false);
                audiotrue = false;
            }
            
        }
    }
    public void CloseAudios()
    {
        if (audio != null)
        {
            audio.SetActive(false);
        }
        if (audio1 != null)
        {
            audio1.SetActive(false);
        }
    }
    public void OpenGameOverUI()
    {
        if (gameOver_panel != null)
        {
            gameOver_panel.SetActive(true);
        }
    }
    public void CloseGameOverUI()
    {
        if (gameOver_panel != null)
        {
            gameOver_panel.SetActive(false);
        }
    }
    public void SetPlayerHealth(float health)
    {
        health_bar.localScale = new Vector3(health/10, 2.8f, 1.0f);
    }
    public void SetHighScoreText()
    {
        highscore_text.text = PlayerPrefs.GetFloat("Highscore2").ToString("f0");
    } 
}
