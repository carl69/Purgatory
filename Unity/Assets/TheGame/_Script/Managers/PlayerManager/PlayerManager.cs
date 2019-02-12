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
    private Dictionary<string, InventoryItems> currentEquipment = new Dictionary<string, InventoryItems>();
    public Dictionary<string, InventoryItems> CurrentEquipment { get { return this.currentEquipment; } }


    // A dictionary with the CURRENT WEAPONS of the player
    private Dictionary<string, InventoryItems> currentWeapons = new Dictionary<string, InventoryItems>();
    public Dictionary<string, InventoryItems> CurrentWeapons { get { return this.currentWeapons; } }


    // A dictionary with the CURRENT ATTACKS of the player
    private Dictionary<string, InventoryItems> currentAttacks = new Dictionary<string, InventoryItems>();
    public Dictionary<string, InventoryItems> CurrentAttacks { get { return this.currentAttacks; } }


    // Inventory Items for the equipment
    InventoryItems helmet = new InventoryItems("Default", 0);
    InventoryItems arm = new InventoryItems("Default", 0);
    InventoryItems chest = new InventoryItems("Default", 0);
    InventoryItems leg = new InventoryItems("Default", 0);

    // Inventory Items for the weapons
    InventoryItems oneHandedWeapon = new InventoryItems("Default", 0);
    InventoryItems twoHandedWeapon = new InventoryItems("Default", 0);

    // Inventory Items for Attacks
    InventoryItems weaponAttack = new InventoryItems("Default", 0);
    InventoryItems SpellAttack = new InventoryItems("Default", 0);



    // Two queues with the COMBOS the player can perform
    private Queue<InventoryItems> comboSet1 = new Queue<InventoryItems>();
    public Queue<InventoryItems> ComboSet1 { get { return this.comboSet1; } }
    private Queue<InventoryItems> comboSet2 = new Queue<InventoryItems>();
    public Queue<InventoryItems> ComboSet2 { get { return this.comboSet2; } }



    
    
    private void Start()
    {
        // Adding each dictionary to the player's inventory
        currentInventory.Add("Equipment", currentEquipment);
        currentInventory.Add("Weapons", currentWeapons);
        currentInventory.Add("Attacks", currentAttacks);

        // Adding the Equipment
        currentEquipment.Add("Helmets", helmet);
        currentEquipment.Add("Arms", arm);
        currentEquipment.Add("Chests", chest);
        currentEquipment.Add("Legs", leg);

        // Adding the wepaons
        currentWeapons.Add("OneHandedWeapons", oneHandedWeapon);
        currentWeapons.Add("TwoHandedWeapons", twoHandedWeapon);

        // Adding the attacks
        currentAttacks.Add("WeaponAttacks", weaponAttack);
        currentAttacks.Add("SpellAttacks", SpellAttack);


        //------------------------------------------------------
        // TESTING: CAN BE DELETED
        comboSet1.Enqueue(spell1);
        comboSet1.Enqueue(weaponatk1);
        comboSet1.Enqueue(spell3);
        //------------------------------------------------------
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
            Debug.Log(currentInventory["Equipment"]["Helmets"].Tag);
    }

}
