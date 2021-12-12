using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnim : MonoBehaviour
{
    private Animator anim;
    private bool hasPlayed = false;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    public void PlayAnimation()
    {
       anim.Play("Key");
    }

}
