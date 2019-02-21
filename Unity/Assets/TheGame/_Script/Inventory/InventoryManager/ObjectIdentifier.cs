using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectIdentifier : MonoBehaviour
{
    public enum TypeOfInventoryItems { Equipment, Attacks, Weapons}
    public enum TypeOfItem { Helmets, Arms, Chests, Legs, WeaponAttacks, SpellAttacks, OneHandedWeapons, TwoHandedWeapons }

    [SerializeField]
    private TypeOfInventoryItems inventoryItem;
    public TypeOfInventoryItems InventoryItem { get { return this.inventoryItem; } }

    [SerializeField]
    private TypeOfItem item;
    public TypeOfItem Item { get { return this.item; } }

    [SerializeField]
    private int objectId;
    public int ObjectId { get { return this.objectId; } }


    
    // I need it public to let the script know I'm referring to that specific inventory
    [SerializeField]
    private Inventory inventory;

    [SerializeField]
    private InventoryManager inventoryManager;


    public void ItemSelected()
    {
        InventoryItems i = inventory.InventoryExtensions.FindInventoryItem(inventoryItem.ToString(), item.ToString(), objectId);

        if (inventoryItem.ToString() == "Attacks")
            inventoryManager.updateCombo("ComboSet1", i);
        else
            inventoryManager.updateGear(inventoryItem.ToString(), item.ToString(), i);
    }

}
