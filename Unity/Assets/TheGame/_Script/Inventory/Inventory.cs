using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    private Dictionary<string, Dictionary<string, List<InventoryItems>>> inventory = new Dictionary<string, Dictionary<string, List<InventoryItems>>>();

    // Equipment dictionary
    private Dictionary<string, List<InventoryItems>> equipment = new Dictionary<string, List<InventoryItems>>();

    // Lists of the equipment dictionary
    [SerializeField]
    private List<Helmet> Helmets = new List<Helmet>();
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
        equipment.Add("Helmets", Helmets.ConvertAll(x => (InventoryItems)x));
        equipment.Add("Arms", Arms);
        equipment.Add("Chests", Chests);
        equipment.Add("Legs", Legs);
    }

    private void Update()
    {
        ////string name = inventory["Equipment"]["Helmets"][0].getTag();
        ////Debug.Log(name);

        //Helmets.ConvertAll(x => (Helmet)x);
        // Example to access a Helmet called "a"
        Helmet h = (Helmet)inventory["Equipment"]["Helmets"].Find(x => x.getTag() == "a");
        float strength = h.getStrength();
        //float s = (Helmet)inventory["Equipment"]["Helmets"][0].getStrength();
        Debug.Log(strength);
    }
}
