using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int money = 3;

        do
        {
            print("I'm Rich! I got " + money + " doolers!!");
            money--;

        } while (money > 10);

        print("Where'd all my money go?!");
    }
}
