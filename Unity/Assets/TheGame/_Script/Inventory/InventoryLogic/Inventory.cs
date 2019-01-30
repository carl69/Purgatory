using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // private InventoryExtensions inventoryExtensions;

    // Inventory dictionary
    private Dictionary<string, Dictionary<string, List<InventoryItems>>> inventory = new Dictionary<string, Dictionary<string, List<InventoryItems>>>();
    public Dictionary<string, Dictionary<string, List<InventoryItems>>> Inventory_ { get { return this.inventory; } }

    //------------------------------------------------------------------------------------------------------------

    // Equipment's struct
    [SerializeField]
    private EquipmentItems equipment = new EquipmentItems();
    public EquipmentItems Equipment { get { return this.equipment; } }
    

    // Equipment's dictionary
    private string equipmentKey = "Equipment";
    public string EquipmentKey { get { return this.equipmentKey; } }
    private Dictionary<string, List<InventoryItems>> Equipment_Dictionary = new Dictionary<string, List<InventoryItems>>();

    //---------------------------------------------------------------------------------------------------------

    // Attacks' dictionary
    private string attacksKey = "Attacks";
    public string AttacksKey { get { return this.attacksKey; } }
    private Dictionary<string, List<InventoryItems>> Attacks = new Dictionary<string, List<InventoryItems>>();

    // Lists of the attacks' dictionary
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
        equipment.HelmetsKey = "Helmets";
        equipment.ArmsKey = "Arms";
        equipment.ChestsKey = "Chests";
        equipment.LegsKey = "Legs";

        // Adding the equipment dictionary and his lists
        inventory.Add(equipmentKey, Equipment_Dictionary);
        Equipment_Dictionary.Add(equipment.HelmetsKey, equipment.Helmets.ConvertAll(x => (InventoryItems)x));
        Equipment_Dictionary.Add(equipment.ArmsKey, equipment.Arms.ConvertAll(x => (InventoryItems)x));
        Equipment_Dictionary.Add(equipment.ChestsKey, equipment.Chests.ConvertAll(x => (InventoryItems)x));
        Equipment_Dictionary.Add(equipment.LegsKey, equipment.Legs.ConvertAll(x => (InventoryItems)x));


        // Adding the cards dictionary and his lists
        inventory.Add(attacksKey, Attacks);
        Equipment_Dictionary.Add(spellAttacksKey, spellAttacks.ConvertAll(x => (InventoryItems)x));
        Equipment_Dictionary.Add(weaponAttacksKey, weaponAttacks.ConvertAll(x => (InventoryItems)x));

        // To access the inventoryExtensions methods
        // inventoryExtensions = GetComponent<InventoryExtensions>();
    }

    private void Update()
    {
        //Debug.Log(inventoryExtensions.FindHelmet(1).HelmetStats_.Strength);
    }

}
