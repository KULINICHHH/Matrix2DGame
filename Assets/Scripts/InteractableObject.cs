using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    [SerializeField]
    protected Sprite sprite;
    protected InventoryControl inventory;
    public bool IsQuestObj = false;
    public QuestObj questObj;
    public UnityEvent theEvent;
    private void Start()
    {
        if(sprite == null)
        {
            sprite = GetComponent<SpriteRenderer>().sprite;
        }
        inventory = Game.instance.inventory;
    }
    public virtual void Interact()
    {       
        if(theEvent != null)
        {
            theEvent.Invoke();
        }
        if (IsQuestObj && questObj!=null)
        {
            int numberInArray = inventory.AddItemInInventory(sprite);
            questObj.canInterract(numberInArray);
            Debug.Log("drggggggggfbhrdb");
            Destroy(gameObject);
        }
    }
}
