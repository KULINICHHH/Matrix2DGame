using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDimension : MonoBehaviour
{
    [SerializeField]
    private GameObject partOfFirstDimension;

    public void OpenorClosePartOfFirstDimension()
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
