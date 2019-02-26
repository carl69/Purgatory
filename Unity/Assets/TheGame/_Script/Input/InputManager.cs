using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public string controllerHorizontalInput;
    public string controllerVerticalInput;

    public string dashInput;
    public string attackInput1;
    public string attackInput2;

    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        axisInputManager();
        dashInputManager();
        attackInputManager();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void dashInputManager()
    {
        if (player.TestingWithKeyBoard)
        {
            dashInput = "dashK";
        }
        else if (player.TestingWithPs4Controller)
        {
            dashInput = "dashPs4Test";
        }
        else if (player.TestingWithXboxController)
        {
            dashInput = "dashXboxTest";
        }
        else
        {
            dashInput = "B"+ player.isDS4 + player.pNumber.ToString();
        }
    }


    void attackInputManager()
    {
        if (player.TestingWithKeyBoard)
        {
            attackInput1 = "attack1K";
            attackInput2 = "attack2K";
        }
        else if (player.TestingWithPs4Controller)
        {
            attackInput1 = "attack1Ps4Test";
            attackInput2 = "attack2Ps4Test";
        }
        else if (player.TestingWithXboxController)
        {
            attackInput1 = "attack1XboxTest";
            attackInput2 = "attack2XboxTest";
        }
        else
        {
            attackInput1 = "X" + player.isDS4 + player.pNumber.ToString();
            attackInput2 = "Y" + player.pNumber.ToString();
        }
    }

    void axisInputManager()
    {

        if (player.TestingWithKeyBoard)
        {
            controllerHorizontalInput = "HorizontalK";
            controllerVerticalInput = "VerticalK";
        }
        else if (player.TestingWithPs4Controller || player.TestingWithXboxController)
        {
            controllerHorizontalInput = "Horizontal1Test";
            controllerVerticalInput = "Vertical1Test";
        }
        else
        {
            controllerHorizontalInput = "Horizontal" + player.pNumber.ToString();
            controllerVerticalInput = "Vertical" + player.pNumber.ToString();
        }

    }
}
