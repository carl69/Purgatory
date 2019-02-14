using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Player STATS
    [SerializeField]
    private int player_id;
    public int Player_id { get { return this.player_id; } }

    [SerializeField]
    private float stamina;
    public float Stamina { get { return this.stamina; } }

    // TESTING: CAN BE DELETED
    //--------------------------------------------------------
    Spell_Attack spell1 = new Spell_Attack("Combo1", 3);
    Weapon_Attack weaponatk1 = new Weapon_Attack("Combo2", 4);
    Spell_Attack spell3 = new Spell_Attack("Combo3", 5);
    //--------------------------------------------------------

    // A dictionary with the CURRENT INVENTORY of the player
    private Dictionary<string, Dictionary<string, InventoryItems>> currentInventory = new Dictionary<string, Dictionary<string, InventoryItems>>();
    public Dictionary<string, Dictionary<string, InventoryItems>> CurrentInventory { get { return this.currentInventory; } }


    // A dictionary with the CURRENT EQUIPMENT of the player
    private string currentEquipmentKey = "Equipment";
    private Dictionary<string, InventoryItems> currentEquipment = new Dictionary<string, InventoryItems>();
    public Dictionary<string, InventoryItems> CurrentEquipment { get { return this.currentEquipment; } }


    // A dictionary with the CURRENT WEAPONS of the player
    private string currentWeaponsKey = "Weapons";
    private Dictionary<string, InventoryItems> currentWeapons = new Dictionary<string, InventoryItems>();
    public Dictionary<string, InventoryItems> CurrentWeapons { get { return this.currentWeapons; } }


    // A dictionary with the CURRENT ATTACKS of the player
    private string currentAttacksKey = "Attacks";
    private Dictionary<string, InventoryItems> currentAttacks = new Dictionary<string, InventoryItems>();
    public Dictionary<string, InventoryItems> CurrentAttacks { get { return this.currentAttacks; } }


    // Inventory Items for the equipment
    private string currentHelmetKey = "Helmets";
    InventoryItems helmet = new InventoryItems("Default", 0);

    private string currentArmKey = "Arms";
    InventoryItems arm = new InventoryItems("Default", 0);

    private string currentChestKey = "Chests";
    InventoryItems chest = new InventoryItems("Default", 0);

    private string currentLegKey = "Legs";
    InventoryItems leg = new InventoryItems("Default", 0);


    // Inventory Items for the weapons
    private string currentOneHandedWeaponKey = "OneHandedWeapons";
    InventoryItems oneHandedWeapon = new InventoryItems("Default", 0);

    private string currentTwoHandedWeaponKey = "TwoHandedWeapons";
    InventoryItems twoHandedWeapon = new InventoryItems("Default", 0);


    // Inventory Items for Attacks
    private string currentWeaponAttackKey = "WeaponAttacks";
    InventoryItems weaponAttack = new InventoryItems("Default", 0);

    private string currentSpellAttackKey = "SpellAttacks";
    InventoryItems SpellAttack = new InventoryItems("Default", 0);



    // Two queues with the COMBOS the player can perform
    private Queue<InventoryItems> comboSet1 = new Queue<InventoryItems>();
    public Queue<InventoryItems> ComboSet1 { get { return this.comboSet1; } }
    private Queue<InventoryItems> comboSet2 = new Queue<InventoryItems>();
    public Queue<InventoryItems> ComboSet2 { get { return this.comboSet2; } }



    
    
    private void Start()
    {

        CreatePlayerInventory();

        //------------------------------------------------------
        // TESTING: CAN BE DELETED
        comboSet1.Enqueue(spell1);
        comboSet1.Enqueue(weaponatk1);
        comboSet1.Enqueue(spell3);
        //------------------------------------------------------
    }

    private void Update()
    {
        // TESTING PURPOSES------------------------------------------
        if (Input.GetKeyDown(KeyCode.T))
            Debug.Log(currentInventory["Equipment"]["Helmets"].Tag);
        // TESTING PURPOSES------------------------------------------
    }

    private void CreatePlayerInventory()
    {
        // Adding each dictionary to the player's inventory
        currentInventory.Add(currentEquipmentKey, currentEquipment);
        currentInventory.Add(currentWeaponsKey, currentWeapons);
        currentInventory.Add(currentAttacksKey, currentAttacks);


        // Adding the Equipment
        currentEquipment.Add(currentHelmetKey, helmet);
        currentEquipment.Add(currentArmKey, arm);
        currentEquipment.Add(currentChestKey, chest);
        currentEquipment.Add(currentLegKey, leg);


        // Adding the wepaons
        currentWeapons.Add(currentOneHandedWeaponKey, oneHandedWeapon);
        currentWeapons.Add(currentTwoHandedWeaponKey, twoHandedWeapon);


        // Adding the attacks
        currentAttacks.Add(currentWeaponAttackKey, weaponAttack);
        currentAttacks.Add(currentSpellAttackKey, SpellAttack);
    }

}
