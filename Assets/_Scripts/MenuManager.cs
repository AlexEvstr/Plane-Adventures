using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _levelsPanel;

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenLevels()
    {
        _levelsPanel.SetActive(true);
    }

    public void CloseLevels()
    {
        _levelsPanel.SetActive(false);
    }
}
