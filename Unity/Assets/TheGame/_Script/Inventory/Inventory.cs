using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    InventoryExtensions inventoryExtensions;

    // Inventory dictionary
    private Dictionary<string, Dictionary<string, List<InventoryItems>>> inventory = new Dictionary<string, Dictionary<string, List<InventoryItems>>>();

    // Equipment dictionary
    private Dictionary<string, List<InventoryItems>> Equipment = new Dictionary<string, List<InventoryItems>>();

    // Lists of the equipment dictionary
    [SerializeField]
    private List<Helmet> Helmets = new List<Helmet>();
    [SerializeField]
    private List<Arm> Arms = new List<Arm>();
    [SerializeField]
    private List<Chest> Chests = new List<Chest>();
    [SerializeField]
    private List<Leg> Legs = new List<Leg>();

    private void Start()
    {

        // Adding the equipment dictionary and his lists
        inventory.Add("Equipment", Equipment);
        Equipment.Add("Helmets", Helmets.ConvertAll(x => (InventoryItems)x));
        Equipment.Add("Arms", Arms.ConvertAll(x => (InventoryItems)x));
        Equipment.Add("Chests", Chests.ConvertAll(x => (InventoryItems)x));
        Equipment.Add("Legs", Legs.ConvertAll(x => (InventoryItems)x));

        // To access the inventoryExtensions methods
        inventoryExtensions = GetComponent<InventoryExtensions>();
    }

    public Dictionary<string, Dictionary<string, List<InventoryItems>>> getInventory()
    {
        return inventory;
    }
}
