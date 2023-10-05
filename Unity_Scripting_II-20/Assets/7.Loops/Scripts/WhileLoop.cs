using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int counter = 0;

        while (counter < 5)
        {
            print("Counting at " + counter);
            counter++;
        }

        print("Counter reached " + counter + ". Exiting loop.");
    }
}
