using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float SpeedHorizontal;

    private Camera mainCamera;


    [SerializeField]
    private LayerMask demention1;
    private LayerMask demention2;

    private Rigidbody2D _playerRb;
    private Transform _playerTransform;

    void Start()
    {
        mainCamera = Camera.main;
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

        if (Input.GetButtonDown("Fire1") )
        {
            Vector2 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            var collider = Physics2D.OverlapPoint(mousePos, demention1);
            if(collider != null)
            {
                InteractableObject interactable = collider.GetComponent<InteractableObject>();
                if(interactable != null)
                {
                    interactable.Interact();
                    Debug.Log(interactable?.name);
                }
            }
        }
    }
}
