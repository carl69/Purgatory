using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    [SerializeField]
    PlayerManager playerManager;


    public void updateGear(string inventoryItem, string listItem, InventoryItems item)
    {
        // Access to playerManager dictionary with the two strings and modify the value assigned to that key
        // myDictionary[myKey] = myNewValue;
    }
}
