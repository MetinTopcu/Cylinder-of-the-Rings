
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    [SerializeField]
    private GameObject soundOnIcon;

    [SerializeField]
    private GameObject soundOffIcon;

    private bool muted = false;

    private AudioSource konumaudio;

    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }

        else
        {
            Load();
        }
        UpdateButtonIcon();
        Camera.main.GetComponent<AudioSource>().enabled = !muted;
        konumaudio = GameObject.FindGameObjectWithTag("mytrigger").GetComponent<AudioSource>();
        konumaudio.enabled = !muted;
    }

    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            Camera.main.GetComponent<AudioSource>().enabled = false;
            konumaudio.enabled = false;
        }
        else
        {
            muted = false;
            Camera.main.GetComponent<AudioSource>().enabled = true;
            konumaudio.enabled = true;
        }
        Save();
        UpdateButtonIcon();
    }

    private void UpdateButtonIcon()
    {
        if (muted == false)
        {
            soundOnIcon.SetActive(true);
            soundOffIcon.SetActive(false);
        }
        else
        {
            soundOnIcon.SetActive(false);
            soundOffIcon.SetActive(true);
        }
    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
