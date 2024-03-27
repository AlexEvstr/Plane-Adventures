using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameButtons : MonoBehaviour
{
    [SerializeField] private GameObject _pause;
    //[SerializeField] private TMP_Text _curerntLevel;

    public void OpenPause()
    {
        _pause.SetActive(true);
        Time.timeScale = 0;
    }

    public void ClosePause()
    {
        _pause.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Game");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void NextLevel()
    {
        GameData.LevelIndex++;
        SceneManager.LoadScene("Game");
    }

    //private void Update()
    //{
    //    _curerntLevel.text = $"Level {GameData.LevelIndex}";
    //}
}
