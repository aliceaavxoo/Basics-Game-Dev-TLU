using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] players;

    // Start is called before the first frame update
    void Start()
    {
        //print("Player 1 name is " + players[0].name);
        //print("Player 2 name is " + players[1].name);
        //print("Player 3 name is " + players[2].name);

        for (int index = 0; index < players.Length; index++)
        {
            print("Player " + (index + 1) + " name is " + players[index].name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
