using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntentoryControl : MonoBehaviour
{
    [SerializeField]
    private Image[] InventoryItems;
    public Sprite[] Items;
    private int count = 0;

    void Start()
    {
        foreach(var obj in Items)
        AddItemInInventory(obj);
        
        for(int i = 0; i < 6; i++)
        RemoveItemInInventory(i);
    }
    public void AddItemInInventory(Sprite _sprite)
    {
        InventoryItems[count].sprite = _sprite;
        count++;
        Debug.Log(count.ToString());
    }
    public void RemoveItemInInventory(int id)
    {
        InventoryItems[id].sprite = null;
    }
}
