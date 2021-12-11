using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObj : InteractableObject
{
    private bool openForInterract = false;
    private int numberInArray;
    public override void Interact()
    {
        if (openForInterract)
        {
            Debug.Log("Geniiiiiiiiiii");
            Game.instance.inventory.RemoveItemInInventory(numberInArray);
        }
    }
    public void canInterract(int NumberInArray)
    {
        openForInterract = true;
        numberInArray = NumberInArray;      
    }
}
