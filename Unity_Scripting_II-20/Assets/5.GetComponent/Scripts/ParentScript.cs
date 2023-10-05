using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentScript : MonoBehaviour
{
    private void Start()
    {
        GetComponentInChildren<SharedScript>().IdentifySelf();
    }

    public void IdentifySelf()
    {
        print("I am ParentScript on " + gameObject.name);
    }
}
