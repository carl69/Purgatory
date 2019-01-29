using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
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
    }

    private void Update()
    {
        //string name = inventory["Equipment"]["Helmets"][0].getTag();
        //Debug.Log(name);


        // Example to access a Helmet called "a"
        //Helmet h = (Helmet)inventory["Equipment"]["Helmets"].Find(x => x.getTag() == "a");
        //float strength = h.getStrength();
        //Debug.Log(strength);

    }

    public Dictionary<string, Dictionary<string, List<InventoryItems>>> getInventory()
    {
        return inventory;
    }
}
