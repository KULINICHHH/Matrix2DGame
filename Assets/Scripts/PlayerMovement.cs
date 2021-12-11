using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float SpeedHorizontal;

    private Animator _animation;
    private Rigidbody2D _playerRb;
    private Transform _playerTransform;
    private SpriteRenderer _spriteRenderer;

    void Start()
    {  
        _playerRb = GetComponent<Rigidbody2D>();
        _playerTransform = GetComponent<Transform>();
        _animation = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float HorizontalMovement = Input.GetAxis("Horizontal");   
        if(HorizontalMovement != 0)
        {
            if(HorizontalMovement < 0)
            {
                _spriteRenderer.flipX = true;
            }
            else
            {
                _spriteRenderer.flipX = false;
            }
            _animation.SetBool("IsRun", true);
            _playerRb.AddForce(_playerTransform.right * SpeedHorizontal * HorizontalMovement);
        }
        else
        {
            _animation.SetBool("IsRun", false);
        }
     
    }
}
