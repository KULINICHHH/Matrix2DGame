using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DyaDyaBoom : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ActivateBoom()
    {
        animator.SetTrigger("IsBoom");
    }
}
