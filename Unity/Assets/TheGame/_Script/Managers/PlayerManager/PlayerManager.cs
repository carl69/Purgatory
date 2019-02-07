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

    // A dictionary with the CURRENT EQUIPMENT of the player
    private Dictionary<string, InventoryItems> currrentEquipment = new Dictionary<string, InventoryItems>();
    public Dictionary<string, InventoryItems> CurrrentEquipment { get { return this.currrentEquipment; } }

    // The WEAPON the player has selected
    private InventoryItems currentWeapon;
    public InventoryItems CurrentWeapon { get { return this.currentWeapon; } }

    // A dictionary with the CURRENT ATTACKS of the player
    private Dictionary<string, InventoryItems> currrentAttacks = new Dictionary<string, InventoryItems>();
    public Dictionary<string, InventoryItems> CurrrentAttacks { get { return this.currrentAttacks; } }

    // Two queues with the COMBOS the player can perform
    private Queue<InventoryItems> comboSet1 = new Queue<InventoryItems>();
    public Queue<InventoryItems> ComboSet1 { get { return this.comboSet1; } }
    private Queue<InventoryItems> comboSet2 = new Queue<InventoryItems>();
    public Queue<InventoryItems> ComboSet2 { get { return this.comboSet2; } }



    // TESTING: CAN BE DELETED
    //------------------------------------------------------
    private void Start()
    {
        comboSet1.Enqueue(spell1);
        comboSet1.Enqueue(weaponatk1);
        comboSet1.Enqueue(spell3);
    }
    //------------------------------------------------------
}
