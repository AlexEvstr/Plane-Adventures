using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _star;

    private Vector2[] _starPositions = {new Vector2 (4,0), new Vector2 (0,4), new Vector2(-4,0), new Vector2(0, -4)};

    private void Start()
    {
        StartCoroutine(SpawnStar());
    }

    public IEnumerator SpawnStar()
    {
        yield return new WaitForSeconds(0.5f);
        GameObject star = Instantiate(_star);
        star.transform.position = _starPositions[Random.Range(0, 4)];
    }
}
