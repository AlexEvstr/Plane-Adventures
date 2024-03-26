using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCollision : MonoBehaviour
{
    [SerializeField] private StarsSpawner _starsSpawner;

    private void Start()
    {
        //_starsSpawner = _starsSpawner.GetComponent<StarsSpawner>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("LUL Game over");
        }
        else if (collision.gameObject.CompareTag("Star"))
        {
            Destroy(collision.gameObject);
            _starsSpawner.SpawnStar();
            Debug.Log("bonus");
        }
    }
}
