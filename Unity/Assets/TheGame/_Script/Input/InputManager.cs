using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public string controllerHorizontalInput;
    public string controllerVerticalInput;

    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();


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

    // Update is called once per frame
    void Update()
    {
        
    }
}
