﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour {
    public Card player;

    float placeholderMovementSpeed = 5;
    float placeholderRotateDampening = 20;

    public Transform placeholderTarget;

    public enum PlayerState
    {
        Walking,Action,Block,dodge
    }
    public PlayerState currentPlayerState;

    public enum Player
    {
        Player_1,Player_2
    }
    public Player ControllingPlayer;

    public List<Card> Combo01;
    public List<Card> Combo02;

	// Use this for initialization
	void Start () {

        GameObject GM = GameObject.FindGameObjectWithTag("GM");
        GM_Cards GmCards = GM.GetComponent<GM_Cards>();

        switch (ControllingPlayer)
        {
            case Player.Player_1:
                Combo01 = GmCards.P1Combo1;
                Combo02 = GmCards.P1Combo2;
                break;
            case Player.Player_2:
                Combo01 = GmCards.P2Combo1;
                Combo02 = GmCards.P2Combo2;
                break;
            default:
                break;
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        switch (currentPlayerState)
        {
            case PlayerState.Walking:
                // very basic looking

                var lookPos = placeholderTarget.position - transform.position;
                lookPos.y = 0;
                var rotation = Quaternion.LookRotation(lookPos);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * placeholderRotateDampening);

                // very basic walking

                Vector3 RIGHT = transform.TransformDirection(Vector3.right);
                Vector3 FORWARD = transform.TransformDirection(Vector3.forward);
                transform.localPosition += RIGHT * Input.GetAxis("Horizontal") * placeholderMovementSpeed / 1.5f * Time.deltaTime; // makes the player move slower to the sides
                transform.localPosition += FORWARD * Input.GetAxis("Vertical") * placeholderMovementSpeed * Time.deltaTime;

                break;
            case PlayerState.Action:

                // Sett animation for the action

                // trigger or enchantment

                // Do the action

                break;

            case PlayerState.Block:
                break;

            case PlayerState.dodge:
                break;

            default:
                break;
        }
    }
}
