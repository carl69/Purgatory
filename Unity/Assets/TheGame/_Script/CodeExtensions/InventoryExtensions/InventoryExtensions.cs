using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryExtensions : MonoBehaviour
{

    private Dictionary<string, Dictionary<string, List<InventoryItems>>> inv;

    private void Start()
    {
        inv = GetComponent<Inventory>().getInventory();
    }

    // Method to find an specific Helmet
    public Helmet FindHelmet(int id)
    {
        Helmet helmet = (Helmet)inv["Equipment"]["Helmets"].Find(x => x.getId() == id);
        return helmet;
    }

    // Method to find an specific Arm
    public Arm FindArm(int id)
    {
        Arm arm = (Arm)inv["Equipment"]["Arms"].Find(x => x.getId() == id);
        return arm;
    }

    // Method to find an specific Chest
    public Chest FindChest(int id)
    {
        Chest chest = (Chest)inv["Equipment"]["Chests"].Find(x => x.getId() == id);
        return chest;
    }

    // Method to find an specific Leg
    public Leg FindLeg(int id)
    {
        Leg leg = (Leg)inv["Equipment"]["Legs"].Find(x => x.getId() == id);
        return leg;
    }


}
