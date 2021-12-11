using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntentoryControl : MonoBehaviour
{
    [SerializeField]
    private Image[] InventoryItems;
    private int count = 0;

    public int AddItemInInventory(Sprite _sprite)
    {
        InventoryItems[count].sprite = _sprite;        
        return count++;
    }
    public void RemoveItemInInventory(int id)
    {
        InventoryItems[id].sprite = null;
    }
}
