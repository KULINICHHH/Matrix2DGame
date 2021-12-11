using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    private Sprite sprite;
    private InventoryControl inventory;
    public bool IsQuestObj = false;
    public QuestObj questObj;
    public UnityEvent theEvent;
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;
        inventory = Game.instance.inventory;
    }
    public virtual void Interact()
    {       
        if(theEvent != null)
        {
            theEvent.Invoke();
        }
        if (IsQuestObj)
        {
            int numberInArray = inventory.AddItemInInventory(sprite);
            questObj.canInterract(numberInArray);
            Destroy(gameObject);
        }
    }
}
