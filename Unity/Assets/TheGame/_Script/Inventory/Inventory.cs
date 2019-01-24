using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Dictionary<string, Dictionary<string, List<InventoryItems>>> inventory = new Dictionary<string, Dictionary<string, List<InventoryItems>>>();

    private Dictionary<string, List<InventoryItems>> equipment = new Dictionary<string, List<InventoryItems>>();

    // Lists of the equipment dictionary
    [SerializeField]
    private List<InventoryItems> Helmets = new List<InventoryItems>();
    [SerializeField]
    private List<InventoryItems> Arms = new List<InventoryItems>();
    [SerializeField]
    private List<InventoryItems> Chests = new List<InventoryItems>();
    [SerializeField]
    private List<InventoryItems> Legs = new List<InventoryItems>();

    private void Start()
    {
        // Adding the equipment dictionary and his lists
        inventory.Add("Equipment", equipment);
        equipment.Add("Helmets", Helmets);
        equipment.Add("Arms", Arms);
        equipment.Add("Chests", Chests);
        equipment.Add("Legs", Legs);
    }
}
