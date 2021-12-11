using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float SpeedHorizontal;

    private Rigidbody2D _playerRb;
    private Transform _playerTransform;

    void Start()
    {
        _playerRb = GetComponent<Rigidbody2D>();
        _playerTransform = GetComponent<Transform>();
    }

    void Update()
    {
        float HorizontalMovement = Input.GetAxis("Horizontal");   
        if(HorizontalMovement != 0)
        {
            _playerRb.AddForce(_playerTransform.right * SpeedHorizontal * HorizontalMovement);
        }
    }
}
