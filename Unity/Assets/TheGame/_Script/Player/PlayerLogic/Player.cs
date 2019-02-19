using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Current state of the player
    private State currentState;

    // Player Manager with the current items of the player
    private PlayerManager playerManager;
    public PlayerManager PlayerManager { get { return this.playerManager; } }


    /// <testing_purposes>
    [SerializeField]
    private char player_Id = ' ';
    public char Player_Id { get { return this.player_Id; } set { this.player_Id = value;  } }

    [SerializeField]
    private bool joyStickActive = false;
    public bool JoyStickActive { get { return this.joyStickActive; } set { this.joyStickActive = value; } }
    /// </testing_purposes>
    /// 
    public int pNumber;

    public string isDS4 = "";



    private void Start()
    {
        playerManager = GetComponent<PlayerManager>();

        SetState(new MovementState(this));
    }

    private void Update()
    {
        currentState.Tick();
    }

    // Method to set a new state
    public void SetState(State state)
    {
        if (currentState != null)
            currentState.OnStateExit();

        currentState = state;

        if (currentState != null)
            currentState.OnStateEnter();
    }

    public void setNumber(int i)
    {
        pNumber = i;
    }

    public void setPS4()
    {
        isDS4 = "PS";
    }
}
