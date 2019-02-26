using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public string controllerHorizontalInput;
    public string controllerVerticalInput;

    public string dashInput;

    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        axisInputManager();
        dashInputManager();
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
