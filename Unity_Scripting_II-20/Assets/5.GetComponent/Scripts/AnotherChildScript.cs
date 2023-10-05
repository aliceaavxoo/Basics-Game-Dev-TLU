using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherChildScript : MonoBehaviour
{
    public int publicNumber = 42;
    private string privateWord = "Secret";

    public void IdentifySelf()
    {
        print("I am AnotherChildScript on " + gameObject.name);
    }

    public string GetTheWord()
    {
        return privateWord;
    }
}
