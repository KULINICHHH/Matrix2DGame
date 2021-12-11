using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetActiveAndInactive : MonoBehaviour
{
    public void OpenorClosePartOfFirstDimension(GameObject partOfFirstDimension)
    {
        if(partOfFirstDimension.active == false)
        {
            partOfFirstDimension.SetActive(true);
        }
        else if (partOfFirstDimension.active == true)
        {
            partOfFirstDimension.SetActive(false);
        }
    }
}
