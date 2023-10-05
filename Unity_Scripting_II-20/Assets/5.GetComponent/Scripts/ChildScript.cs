using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildScript : MonoBehaviour
{
    public AnotherChildScript theOtherScript;
    ParentScript parent;
    SharedScript sharedScript;


    // Start is called before the first frame update
    void Start()
    {
        theOtherScript = GetComponent<AnotherChildScript>();
        theOtherScript.IdentifySelf();
        print("The secret word is: '" + theOtherScript.GetTheWord() + "'");

        parent = GetComponentInParent<ParentScript>();
        parent.IdentifySelf();

        //sharedScript = GetComponentInParent<SharedScript>();
        //sharedScript.IdentifySelf();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
