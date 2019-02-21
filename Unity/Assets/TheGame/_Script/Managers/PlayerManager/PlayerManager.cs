using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // A variable to access code extensions
    private PlayerManagerExtensions playerManagerExtensions;
    public PlayerManagerExtensions PlayerManagerExtensions { get { return this.playerManagerExtensions; } }

    // Player STATS
    [SerializeField]
    private int player_id;
    public int Player_id { get { return this.player_id; } }

    [SerializeField]
    private float allowedTimeBetweenAttacks = 1.5f;
    public float AllowedTimeBetweenAttacks { get { return this.allowedTimeBetweenAttacks; } }

    [SerializeField]
    private float stamina;
    public float Stamina { get { return this.stamina; } }

    // A variable to be able to have access to the player
    private Player player;
    public Player Player { get { return this.player; } }


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

    //----------------------------------------------------------------------------------
    // A dictionary with the CURRENT ATTACKS of the player
    private Dictionary<string, Queue<Weapon_Attack>> currentCombos = new Dictionary<string, Queue<Weapon_Attack>>();
    public Dictionary<string, Queue<Weapon_Attack>> CurrentCombos { get { return this.currentCombos; } }
    //-----------------------------------------------------------------------------------

    // Inventory Items for the equipment
    private string currentHelmetKey = "Helmets";
    private InventoryItems helmet = new InventoryItems("Default", 0);

    private string currentArmKey = "Arms";
    private InventoryItems arm = new InventoryItems("Default", 0);

    private string currentChestKey = "Chests";
    private InventoryItems chest = new InventoryItems("Default", 0);

    private string currentLegKey = "Legs";
    private InventoryItems leg = new InventoryItems("Default", 0);


    // Inventory Items for the weapons
    private string currentOneHandedWeaponKey = "OneHandedWeapons";
    private InventoryItems oneHandedWeapon = new InventoryItems("Default", 0);

    private string currentTwoHandedWeaponKey = "TwoHandedWeapons";
    private InventoryItems twoHandedWeapon = new InventoryItems("Default", 0);


    // Inventory Items for Attacks
    //private string currentWeaponAttacksKey = "WeaponAttacks";
    //private InventoryItems WeaponAttack = new InventoryItems("Default", 0);

    //private string currentSpellAttacksKey = "SpellAttacks";
    //private InventoryItems SpellAttack = new InventoryItems("Default", 0);


    // A queue with the first combo set the player can perform
    private string currentCombo1Key = "ComboSet1";
    private Queue<Weapon_Attack> comboSet1 = new Queue<Weapon_Attack>();
    public Queue<Weapon_Attack> ComboSet1 { get { return this.comboSet1; } }

    // A queue with the second combo set the player can perform
    private string currentCombo2Key = "ComboSet2";
    private Queue<Weapon_Attack> comboSet2 = new Queue<Weapon_Attack>();
    public Queue<Weapon_Attack> ComboSet2 { get { return this.comboSet2; } }


    //------------------------------------------------------
    // TESTING: CAN BE DELETED
    Weapon_Attack atk1 = new Weapon_Attack("Attack 1", 1, "Attack");
    Weapon_Attack atk2 = new Weapon_Attack("Attack 2", 2, "Attack");
    Weapon_Attack atk3 = new Weapon_Attack("Attack 3", 3, "Attack");
    //------------------------------------------------------


    private void Start()
    {
        CreatePlayerInventory();

        playerManagerExtensions.addAttackToCombo(comboSet1, atk1);
        playerManagerExtensions.addAttackToCombo(comboSet1, atk2);
        playerManagerExtensions.addAttackToCombo(comboSet1, atk3);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            playerManagerExtensions.executeComboSet(comboSet1);
        }     
    }

    private void CreatePlayerInventory()
    {
        // Adding each dictionary to the player's inventory
        currentInventory.Add(currentEquipmentKey, currentEquipment);
        currentInventory.Add(currentWeaponsKey, currentWeapons);
        //currentInventory.Add(currentAttacksKey, currentAttacks);


        // Adding the Equipment
        currentEquipment.Add(currentHelmetKey, helmet);
        currentEquipment.Add(currentArmKey, arm);
        currentEquipment.Add(currentChestKey, chest);
        currentEquipment.Add(currentLegKey, leg);


        // Adding the wepaons
        currentWeapons.Add(currentOneHandedWeaponKey, oneHandedWeapon);
        currentWeapons.Add(currentTwoHandedWeaponKey, twoHandedWeapon);


        // Adding the attacks
        //currentAttacks.Add(currentWeaponAttacksKey, WeaponAttack);
        //currentAttacks.Add(currentSpellAttacksKey, SpellAttack);
        currentCombos.Add(currentCombo1Key, comboSet1);
        currentCombos.Add(currentCombo2Key, comboSet2);

        playerManagerExtensions = GetComponent<PlayerManagerExtensions>();
    }

}
