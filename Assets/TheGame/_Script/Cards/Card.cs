using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Card")]
public class Card : ScriptableObject
{
    public string Name;
    [TextArea]
    public string Description;
    
    public Sprite CardSprite;

    public enum cardType
    {
        Attack,Enchant
    }
    public cardType CardType;

}
