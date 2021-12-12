using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSceneLoader : MonoBehaviour
{
    [SerializeField]
    GameObject Dimension3;
    [SerializeField]
    GameObject Dimension2;
    [SerializeField]
    GameObject Dimension1;
    public void CheckFishInInventory(int dimension)
    {
        if(dimension == 1)
        {
            Dimension2.active = true;
            Dimension1.active = false;         
        }
        else
        {
            Dimension3.active = true;
            Dimension1.active = false;
        }
    }
}
