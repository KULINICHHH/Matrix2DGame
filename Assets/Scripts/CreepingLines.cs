using UnityEngine;
using System;

public class CreepingLines : MonoBehaviour
{
    public GameObject Number;
    private int count = 0;
    void FixedUpdate()
    {
        if(count++ == 2)
        {
            Instantiate(Number);
        }
    }
}
