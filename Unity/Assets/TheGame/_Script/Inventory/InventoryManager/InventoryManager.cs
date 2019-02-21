using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    [SerializeField]
    private PlayerManager playerManager;


    public void updateGear(string inventoryItem, string listItem, InventoryItems item)
    {
        playerManager.CurrentInventory[inventoryItem][listItem] = item;
    }

    public void updateCombo(string comboSet, InventoryItems attack)
    {
        playerManager.PlayerManagerExtensions.addAttackToCombo(playerManager.ComboSet1,(Weapon_Attack) attack);
    }

    private void Update()
    {
        InventoryItems ad = new InventoryItems("AttackSword", 1);
        if (Input.GetKeyDown(KeyCode.Y))
        {
            updateCombo("a", ad);
            Debug.Log(playerManager.ComboSet1.Dequeue().Tag);
        }
            
    }
}
