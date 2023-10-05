using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharedScript : MonoBehaviour
{
    public void IdentifySelf()
    {
        print("I am SharedScript on " + gameObject.name);
    }
}
