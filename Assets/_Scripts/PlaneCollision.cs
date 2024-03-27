using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlaneCollision : MonoBehaviour
{
    [SerializeField] private StarsSpawner _starsSpawner;
    [SerializeField] private TMP_Text _startCountText;
    [SerializeField] private GameObject _lose;
    [SerializeField] private GameObject _win;
    [SerializeField] private TMP_Text _levelComplete;
    [SerializeField] private TMP_Text _level;

    private int _currentStars;
    private int _starsGoal;

    private void Start()
    {
        Time.timeScale = 1;
        _currentStars = 0;
        _starsGoal = 9;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            _lose.SetActive(true);
            Time.timeScale = 0;
        }
        else if (collision.gameObject.CompareTag("Star"))
        {
            Destroy(collision.gameObject);
            _currentStars++;
            if (_currentStars < _starsGoal)
            {
                StartCoroutine(_starsSpawner.SpawnStar());
            }

            else
            {
                _win.SetActive(true);
                Time.timeScale = 0;
                _levelComplete.text = $"Level {GameData.LevelIndex} complete!";
            }
        }
    }

    private void Update()
    {
        _startCountText.text = $"{_currentStars}/{_starsGoal}";
        _level.text = $"LEVEL {GameData.LevelIndex}";
    }

}
