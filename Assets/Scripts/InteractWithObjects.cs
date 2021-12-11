using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithObjects : MonoBehaviour
{
    [SerializeField]
    private LayerMask demention1;
    private LayerMask demention2;

    [SerializeField]
    private int radiusOfClick;

    private Camera mainCamera;
    private void Start()
    {
        mainCamera = Camera.main;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector2 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            int distance = (int)Vector2.Distance(gameObject.transform.position, mousePos);
            var collider = Physics2D.OverlapPoint(mousePos, demention1);
            if (collider != null && distance<= radiusOfClick)
            {
                InteractableObject interactable = collider.GetComponent<InteractableObject>();
                if (interactable != null)
                {
                    interactable.Interact();
                    //Debug.Log(interactable?.name);
                }
            }
        }
    }
}
