using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int index = 10; index >= 0; index--)
        {
            print("Counting at " + index);
        }

        print("finished counting");
    }
}
