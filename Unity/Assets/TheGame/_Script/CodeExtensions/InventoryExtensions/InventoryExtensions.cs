using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryExtensions : MonoBehaviour
{ 
    private Inventory inv;

    private void Start()
    {
        inv = GetComponent<Inventory>();
    }

    //// Method to find an specific inventoryItem
    //public InventoryItems FindInventoryItem(string InventoryItem, string TypeofItem, int itemId)
    //{
    //    InventoryItems item = inv.Inventory_[InventoryItem][TypeofItem].Find(x => x.Id == itemId); 
    //    return item;
    //}

    // TEST-------------------------------------------------------------------------------------------
    // Method to find an specific inventoryItem
    public InventoryItems FindInventoryItem(string InventoryItem, string TypeofItem, int itemId)
    {
        InventoryItems item = inv.Inventory_[InventoryItem][TypeofItem].Find(x => x.Id == itemId);
        return item;
    }
    //-------------------------------------------------------------------------------------------------

    // Method to find an specific Helmet
    public Helmet FindHelmet(int HelmetId)
    {
        Helmet helmet = (Helmet) FindInventoryItem(inv.EquipmentKey, inv.Equipment.HelmetsKey, HelmetId);
        //Helmet helmet = (Helmet)inv.Inventory_[inv.EquipmentKey][inv.Equipment.HelmetsKey].Find(x => x.Id == HelmetId);
        return helmet;
    }

    // Method to find an specific Arm
    public Arm FindArm(int ArmId)
    {
        Arm arm = (Arm) inv.Inventory_[inv.EquipmentKey][inv.Equipment.ArmsKey].Find(x => x.Id == ArmId);
        return arm;
    }

    // Method to find an specific Chest
    public Chest FindChest(int ChestId)
    {
        Chest chest = (Chest) inv.Inventory_[inv.EquipmentKey][inv.Equipment.ChestsKey].Find(x => x.Id == ChestId);
        return chest;
    }

    // Method to find an specific Leg
    public Leg FindLeg(int LegId)
    {
        Leg leg = (Leg) inv.Inventory_[inv.EquipmentKey][inv.Equipment.LegsKey].Find(x => x.Id == LegId);
        return leg;
    }

    // Method to find an specific Magic Attack

    // Method to find an specific Magic Attack
}
