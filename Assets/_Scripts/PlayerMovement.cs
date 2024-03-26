using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject _plane;
    private float _speed = 0.25f;

    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, 360) * Time.deltaTime * _speed);
    }

    public void TapScreen()
    {
        _speed = -_speed;
        _plane.transform.Rotate(new Vector3(0, 180, 0));
    }
}
