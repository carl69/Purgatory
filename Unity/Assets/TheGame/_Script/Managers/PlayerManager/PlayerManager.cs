using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // A variable to access the combo system
    private ComboSystem comboSystem;
    public ComboSystem ComboSystem { get { return this.comboSystem; } }

    // Player STATS
    [SerializeField]
    private int player_id;
    public int Player_id { get { return this.player_id; } }

    [SerializeField]
    private float stamina;
    public float Stamina { get { return this.stamina; } }

    // A variable to be able to have access to the player
    private Player player;
    public Player Player { get { return this.player; } }


    // A dictionary with the CURRENT INVENTORY of the player
    //private Dictionary<string, Dictionary<string, InventoryItems>> currentInventory = new Dictionary<string, Dictionary<string, InventoryItems>>();
    //public Dictionary<string, Dictionary<string, InventoryItems>> CurrentInventory { get { return this.currentInventory; } }


    //// A dictionary with the CURRENT EQUIPMENT of the player
    //private string currentEquipmentKey = "Equipment";
    //private Dictionary<string, InventoryItems> currentEquipment = new Dictionary<string, InventoryItems>();
    //public Dictionary<string, InventoryItems> CurrentEquipment { get { return this.currentEquipment; } }


    //// A dictionary with the CURRENT WEAPONS of the player
    //private string currentWeaponsKey = "Weapons";
    //private Dictionary<string, InventoryItems> currentWeapons = new Dictionary<string, InventoryItems>();
    //public Dictionary<string, InventoryItems> CurrentWeapons { get { return this.currentWeapons; } }

    ////----------------------------------------------------------------------------------
    //// A dictionary with the CURRENT ATTACKS of the player
    //private Dictionary<string, Queue<Weapon_Attack>> currentCombos = new Dictionary<string, Queue<Weapon_Attack>>();
    //public Dictionary<string, Queue<Weapon_Attack>> CurrentCombos { get { return this.currentCombos; } }
    //-----------------------------------------------------------------------------------

    // Inventory Items for the equipment
    //private string currentHelmetKey = "Helmets";
    //private InventoryItems helmet = new InventoryItems("Default", 0);

    //private string currentArmKey = "Arms";
    //private InventoryItems arm = new InventoryItems("Default", 0);

    //private string currentChestKey = "Chests";
    //private InventoryItems chest = new InventoryItems("Default", 0);

    //private string currentLegKey = "Legs";
    //private InventoryItems leg = new InventoryItems("Default", 0);


    // Inventory Items for the weapons
    //private string currentOneHandedWeaponKey = "OneHandedWeapons";
    //private InventoryItems oneHandedWeapon = new InventoryItems("Default", 0);

    //private string currentTwoHandedWeaponKey = "TwoHandedWeapons";
    //private InventoryItems twoHandedWeapon = new InventoryItems("Default", 0);


    // Inventory Items for Attacks
    //private string currentWeaponAttacksKey = "WeaponAttacks";
    //private InventoryItems WeaponAttack = new InventoryItems("Default", 0);

    //private string currentSpellAttacksKey = "SpellAttacks";
    //private InventoryItems SpellAttack = new InventoryItems("Default", 0);


    // NEW PLAYERMANAGER STORING SYSTEM

    // Current helmet
    private Helmet currentHelmet;
    public Helmet CurrentHelmet { get { return this.currentHelmet; } set { this.currentHelmet = value; } }

    // Current arm
    private Arm currentArm;
    public Arm CurrentArm { get { return this.currentArm; } set { this.currentArm = value; } }

    // Current chest
    private Chest currentChest;
    public Chest CurrentChest { get { return this.currentChest; } set { this.currentChest = value; } }

    // Current leg
    private Leg currentLeg;
    public Leg CurrentLeg { get { return this.currentLeg; } set { this.currentLeg = value; } }

    // Current OneHandedWeapons
    private OneHandedWeapon currentOneHandedWeapon;
    public OneHandedWeapon CurrentOneHandedWeapon { get { return this.currentOneHandedWeapon; } set { this.currentOneHandedWeapon = value; } }

    // Current TwoHandedWeapons
    private TwoHandedWeapon currentTwoHandedWeapon;
    public TwoHandedWeapon CurrentTwoHandedWeapon { get { return this.currentTwoHandedWeapon; } set { this.currentTwoHandedWeapon = value; } }

    // A queue with the first combo set the player can perform
    private Queue<Weapon_Attack> comboSet1 = new Queue<Weapon_Attack>();
    public Queue<Weapon_Attack> ComboSet1 { get { return this.comboSet1; } }

    // A queue with the second combo set the player can perform
    private Queue<Weapon_Attack> comboSet2 = new Queue<Weapon_Attack>();
    public Queue<Weapon_Attack> ComboSet2 { get { return this.comboSet2; } }


    //------------------------------------------------------
    // TESTING: CAN BE DELETED
    Weapon_Attack atk1_1 = new Weapon_Attack("Attack 1_Combo1", 1, "Attack");
    Weapon_Attack atk2_1 = new Weapon_Attack("Attack 2_Combo1", 2, "Attack");
    Weapon_Attack atk3_1 = new Weapon_Attack("Attack 3_Combo1", 3, "Attack");
    //------------------------------------------------------

    //------------------------------------------------------
    // TESTING: CAN BE DELETED
    Weapon_Attack atk1_2 = new Weapon_Attack("Attack 1_Combo2", 1, "Attack");
    Weapon_Attack atk2_2 = new Weapon_Attack("Attack 2_Combo2", 2, "Attack");
    Weapon_Attack atk3_2 = new Weapon_Attack("Attack 3_Combo3", 3, "Attack");
    //------------------------------------------------------

    [SerializeField]
    [Range(1.0f, 20.0f)]
    private int dashDistance;
    public float DashDistance { get { return this.dashDistance; } }

    [Range(1.0f, 20.0f)]
    public int playerSpeed;


    private void Start()
    {
        CreatePlayerInventory();

        comboSystem.addAttackToCombo(comboSet1, atk1_1);
        comboSystem.addAttackToCombo(comboSet1, atk2_1);
        comboSystem.addAttackToCombo(comboSet1, atk3_1);

        comboSystem.addAttackToCombo(comboSet2, atk1_2);
        comboSystem.addAttackToCombo(comboSet2, atk2_2);
        comboSystem.addAttackToCombo(comboSet2, atk3_2);
    }

    private void CreatePlayerInventory()
    {
        // Adding each dictionary to the player's inventory
        //currentInventory.Add(currentEquipmentKey, currentEquipment);
        //currentInventory.Add(currentWeaponsKey, currentWeapons);
        ////currentInventory.Add(currentAttacksKey, currentAttacks);


        //// Adding the Equipment
        //currentEquipment.Add(currentHelmetKey, helmet);
        //currentEquipment.Add(currentArmKey, arm);
        //currentEquipment.Add(currentChestKey, chest);
        //currentEquipment.Add(currentLegKey, leg);


        //// Adding the wepaons
        //currentWeapons.Add(currentOneHandedWeaponKey, oneHandedWeapon);
        //currentWeapons.Add(currentTwoHandedWeaponKey, twoHandedWeapon);


        //// Adding the attacks
        ////currentAttacks.Add(currentWeaponAttacksKey, WeaponAttack);
        ////currentAttacks.Add(currentSpellAttacksKey, SpellAttack);
        //currentCombos.Add(currentCombo1Key, comboSet1);
        //currentCombos.Add(currentCombo2Key, comboSet2);

        comboSystem = GetComponent<ComboSystem>();
    }

}
