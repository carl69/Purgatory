using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectIdentifier : MonoBehaviour
{
    public enum TypeOfInventoryItems { Equipment, Attacks, Weapons}
    public enum TypeOfItem { Helmet, Arm, Chest, Leg}

    [SerializeField]
    private TypeOfInventoryItems inventoryItem;
    public TypeOfInventoryItems InventoryItem { get { return this.inventoryItem; } }

    [SerializeField]
    private TypeOfItem item;
    public TypeOfItem Item { get { return this.item; } }

    [SerializeField]
    private int objectId;
    public int ObjectId { get { return this.objectId; } }
}
