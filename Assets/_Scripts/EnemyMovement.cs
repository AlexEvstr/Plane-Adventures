using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float _speed = 1.0f;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * Time.deltaTime * _speed);
        if (((transform.position.x < 5 && transform.position.x > 1) || (transform.position.x < -1 && transform.position.x > -5))
        || ((transform.position.y < 5 && transform.position.y > 1) || (transform.position.y < -1 && transform.position.y > -5)))
        {
            return;
        }
        else
        {
            _speed = -_speed;
        }
        
    }
}
