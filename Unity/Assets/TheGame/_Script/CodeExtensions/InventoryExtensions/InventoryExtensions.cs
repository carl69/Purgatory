using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InventoryExtensions
{
    [SerializeField]
    private static Inventory inventory;

    private static Dictionary<string, Dictionary<string, List<InventoryItems>>> inv;

    public static Helmet FindHelmet(this int id)
    {
        inv = inventory.getInventory();
        Helmet helmet = (Helmet)inv["Equipment"]["Helmets"].Find(x => x.getId() == id);
        return helmet;
    }
}
