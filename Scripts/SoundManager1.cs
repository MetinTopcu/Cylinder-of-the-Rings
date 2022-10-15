
using UnityEngine;

public class SoundManager1 : MonoBehaviour
{

    [SerializeField]
    private GameObject soundOnIcon;

    [SerializeField]
    private GameObject soundOffIcon;

    private bool muted = false;

    private AudioSource music;

    void Start()
    {
        music = GameObject.Find("Music").GetComponent<AudioSource>();
        if (!PlayerPrefs.HasKey("muted1"))
        {
            PlayerPrefs.SetInt("muted1", 0);
            Load();
        }

        else
        {
            Load();
        }
        UpdateButtonIcon();
        music.enabled = !muted;
    }

    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            music.enabled = false;
        }
        else
        {
            muted = false;
            music.enabled = true;
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
        muted = PlayerPrefs.GetInt("muted1") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted1", muted ? 1 : 0);
    }
}
