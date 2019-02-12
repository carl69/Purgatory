using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    [SerializeField]
    private PlayerManager playerManager;


    public void updateGear(string inventoryItem, string listItem, InventoryItems item)
    {
        playerManager.CurrentInventory[inventoryItem][listItem] = item;
    }
}
