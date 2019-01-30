using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Card")]
public class Card : ScriptableObject
{
    public string Name;
    [TextArea]
    public string Description;
    [Space]
    public int ComboCost; // how much the card cost in a combo
    public float StaminaCost; // how much stamina is drained from using this card

    public enum cardType
    {
        Attack,Magic
    }
    public cardType CardType; // the type of the card
    [Space]
    public Sprite CardSprite;
    public Animation AttackAnimation;

    public float damage;
}