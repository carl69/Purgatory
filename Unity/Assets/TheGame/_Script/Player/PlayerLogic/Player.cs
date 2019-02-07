using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Current state of the player
    private State currentState;


    /// <testing_purposes>
    [SerializeField]
    private char player_Id = ' ';

    public char Player_Id { get { return this.player_Id; } set { this.player_Id = value;  } }
    /// </testing_purposes>


    
    private void Start()
    {
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
}
