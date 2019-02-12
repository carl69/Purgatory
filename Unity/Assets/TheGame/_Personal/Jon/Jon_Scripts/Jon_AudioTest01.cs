using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jon_AudioTest01 : MonoBehaviour
{
    public GameObject[] PlayersArray;

    public GameObject Player01Audio;
    public GameObject Player02Audio;


    // Start is called before the first frame update
    void Start()
    {
        PlayersArray = GameObject.FindGameObjectsWithTag("Player");
        print(PlayersArray[0].GetComponent<Player>().Player_Id);
        if (PlayersArray[0].GetComponent<Player>().Player_Id.ToString() == "1")
        {
            print("id 1");
            Player01Audio = PlayersArray[0];
            if (PlayersArray.Length > 1)
            {

                Player02Audio = PlayersArray[1];

            }
        }
        else
        {
            if (PlayersArray.Length > 1)
            {
                Player01Audio = PlayersArray[1];
            }
            Player02Audio = PlayersArray[0];
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
