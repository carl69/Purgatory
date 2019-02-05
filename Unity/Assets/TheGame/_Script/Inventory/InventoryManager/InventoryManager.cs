using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField]
    private GameObject inventory;
    private Inventory inv_;
    string inventoryItem;

    InventoryItems item;
    int objectId;

    private void Start()
    {
        inv_ = inventory.GetComponent<Inventory>();
    }

    public void gearSelected()
    {
        //objectId = GetComponent<ObjectIdentifier>().ObjectId;
        InventoryItems it = inv_.InventoryExtensions.FindInventoryItem("Equipment", "Helmets", 1);
        Debug.Log(it.Tag);

    }
}
