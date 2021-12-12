using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatsObject : MonoBehaviour
{
    [SerializeField]
    private CatQuestObj cat;

    public void OnPickUp()
    {
        cat.fishPickedUped = true;
    }
 
}
