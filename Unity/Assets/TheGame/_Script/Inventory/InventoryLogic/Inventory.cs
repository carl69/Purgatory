using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private InventoryExtensions inventoryExtensions;

    // Inventory dictionary
    private Dictionary<string, Dictionary<string, List<InventoryItems>>> inventory = new Dictionary<string, Dictionary<string, List<InventoryItems>>>();
    public Dictionary<string, Dictionary<string, List<InventoryItems>>> Inventory_ { get { return this.inventory; } }

    //------------------------------------------------------------------------------------------------------------
    
    // Equipment dictionary
    private string equipmentKey = "Equipment";
    public string EquipmentKey { get { return this.equipmentKey; } }
    private Dictionary<string, List<InventoryItems>> Equipment = new Dictionary<string, List<InventoryItems>>();

    // Lists of the equipment dictionary
    private string helmetsKey = "Helmets";
    public string HelmetsKey { get { return this.helmetsKey; } }
    [SerializeField]
    private List<Helmet> Helmets = new List<Helmet>();

    private string armsKey = "Arms";
    public string ArmsKey { get { return this.armsKey; } }
    [SerializeField]
    private List<Arm> Arms = new List<Arm>();

    private string chestsKey = "Chests";
    public string ChestsKey { get { return this.chestsKey; } }
    [SerializeField]
    private List<Chest> Chests = new List<Chest>();

    private string legsKey = "Legs";
    public string LegsKey { get { return this.legsKey; } }
    [SerializeField]
    private List<Leg> Legs = new List<Leg>();

    //---------------------------------------------------------------------------------------------------------
    
        // Attacks dictionary
    private string attacksKey = "Attacks";
    public string AttacksKey { get { return this.attacksKey; } }
    private Dictionary<string, List<InventoryItems>> Attacks = new Dictionary<string, List<InventoryItems>>();

    // Lists of the attacks dictionary
    private string spellAttacksKey = "SpellAttacks";
    public string SpellAttacksKey { get { return this.spellAttacksKey; } }
    [SerializeField]
    private List<Spell_Attack> spellAttacks = new List<Spell_Attack>();

    private string weaponAttacksKey = "WeaponAttacks";
    public string WeaponAttacksKey { get { return this.weaponAttacksKey; } }
    [SerializeField]
    private List<Weapon_Attack> weaponAttacks = new List<Weapon_Attack>();

    private void Start()
    {

        // Adding the equipment dictionary and his lists
        inventory.Add(equipmentKey, Equipment);
        Equipment.Add(helmetsKey, Helmets.ConvertAll(x => (InventoryItems)x));
        Equipment.Add(armsKey, Arms.ConvertAll(x => (InventoryItems)x));
        Equipment.Add(chestsKey, Chests.ConvertAll(x => (InventoryItems)x));
        Equipment.Add(legsKey, Legs.ConvertAll(x => (InventoryItems)x));


        // Adding the cards dictionary and his lists
        inventory.Add(attacksKey, Attacks);
        Equipment.Add(spellAttacksKey, spellAttacks.ConvertAll(x => (InventoryItems)x));
        Equipment.Add(weaponAttacksKey, weaponAttacks.ConvertAll(x => (InventoryItems)x));

        // To access the inventoryExtensions methods
        inventoryExtensions = GetComponent<InventoryExtensions>();
    }

    private void Update()
    {
        Debug.Log(inventoryExtensions.FindHelmet(1).Strength);
    }
}
