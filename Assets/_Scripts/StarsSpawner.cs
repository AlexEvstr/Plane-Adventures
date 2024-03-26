using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _star;
    private Vector2[] _starPositions = {new Vector2 (4,0), new Vector2 (0,4), new Vector2(-4,0), new Vector2(0, -4)};

    private void Start()
    {
        SpawnStar();
    }

    public void SpawnStar()
    {
        GameObject star = Instantiate(_star);
        star.transform.position = _starPositions[Random.Range(0, 4)];
        Debug.Log(Random.Range(0, 4));
    }
}
