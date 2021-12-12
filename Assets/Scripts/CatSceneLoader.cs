using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSceneLoader : MonoBehaviour
{
    [SerializeField]
    GameObject Dimension2;
    [SerializeField]
    GameObject Dimension1;
    public void CheckFishInInventory()
    {
         Dimension2.active = true;
         Dimension1.active = false;
    }
}
