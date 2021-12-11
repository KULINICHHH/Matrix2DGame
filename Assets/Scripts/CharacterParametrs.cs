
using System.Collections.Generic;
using UnityEngine;

public class CharacterParametrs : MonoBehaviour
{
    [SerializeField]
    private List<Sprite> Inventory;

    public void AddItemInInventory(Sprite _sprite)
    {
        Inventory.Add(_sprite);
    }
    public void RemoveItemInInventory(Sprite _sprite)
    {
        Inventory.Add(_sprite);
    }
    public bool CheckElement(Sprite _sprite)
    {
        return Inventory.Contains(_sprite);
    }
}
