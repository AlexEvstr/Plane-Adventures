using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelChooser : MonoBehaviour
{
    private void Start()
    {
        int index = int.Parse(gameObject.name);
        if (index <= GameData.UnlockedLevels)
        {
            gameObject.GetComponent<Button>().enabled = true;
            gameObject.GetComponent<Image>().color = new Color(1, 1, 1);
        }
        else
        {
            gameObject.GetComponent<Button>().enabled = false;
            gameObject.GetComponent<Image>().color = Color.grey;
        }
    }

    public void ClickOnLevel()
    {
        int index = int.Parse(gameObject.name);
        GameData.LevelIndex = index;
        Debug.Log(index);
        SceneManager.LoadScene("Game");
    }
}
