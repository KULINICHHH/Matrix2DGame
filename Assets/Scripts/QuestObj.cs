using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObj : InteractableObject
{
    public bool openForInterract = false;
    public bool needToAddObj;
    private int numberInArray;
    public override void Interact()
    {
        if (openForInterract)
        {
            Debug.Log("Geniiiiiiiiiii");
            if (theEvent != null)
            {
                theEvent.Invoke();
            }
            Game.instance.inventory.RemoveItemInInventory(numberInArray);
            if (needToAddObj)
            {
                base.Interact();
              //  int numberInArray = inventory.AddItemInInventory(sprite);
              //  questObj.canInterract(numberInArray);
            }
            if (Destroy)
            {
                Destroy(gameObject);
            }
        }
    }
    public void canInterract(int NumberInArray)
    {
        openForInterract = true;
        numberInArray = NumberInArray;      
    }
}
