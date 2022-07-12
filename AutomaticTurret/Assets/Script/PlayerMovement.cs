using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _input;
    public Rigidbody _playerRigidBody;
    public float speed = 8.0f;
    
    void Start()
    {
        _input = GetComponent<PlayerInput>();
        _playerRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (_input.UP)
        {
            _playerRigidBody.AddForce(0f, 0f, speed);
        }

        if (_input.DOWN)
        {
            _playerRigidBody.AddForce(0f, 0f, -speed);
        }

        if (_input.RIGHT)
        {
            _playerRigidBody.AddForce(-speed, 0f, 0f);
        }

        if (_input.LEFT)
        {
            _playerRigidBody.AddForce(speed, 0f, 0f);
        }
    }
}
