using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private GameObject _musicOn;
    [SerializeField] private GameObject _musicOff;

    public void MusicOff()
    {
        _musicOff.SetActive(true);
        _musicOn.SetActive(false);
        AudioListener.volume = 0;
    }

    public void MusicOn()
    {
        _musicOff.SetActive(false);
        _musicOn.SetActive(true);
        AudioListener.volume = 1;
    }

    private void OnEnable()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("music", 1);
        if (AudioListener.volume == 1)
        {
            MusicOn();
        }
        else
        {
            MusicOff();
        }
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat("music", AudioListener.volume);
    }
}
