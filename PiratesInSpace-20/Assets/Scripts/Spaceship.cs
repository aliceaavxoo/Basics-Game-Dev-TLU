using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
	// Consider the naming style. variables start with a small letter
    string modelName = "Starfarer V";
    int numCrewMembers = 70;
    float fuelLevel = 100f;
    float lowFuelLevel = 50f;

	// boolean variables usually start with "is", "has", "are", etc in their name
	// A yes/no question style, to understand that this variable is a bool
    bool isTankEmpty = false;
	
    
    /*
     * *** Data Types ***
     * string -> text: 		"strings must be in double quotes"
     * int -> integer:  	1, 0, 3291572, -4546
     * float -> decimal: 	0.5f, 6733.3567, 3.14, -45.456
     * bool -> boolean:  	true / false
     * 
	 *
     * *** Arithmetic Operations ***
     * addition 		+
     * subtraction 		-
     * multiplication 	*
     * division 		/
     * modulus 			%
     * 
	 *
     * *** Comparison Operations ***
     * Greater than     		>
     * Less than        		<
     * Greater than or equal    >=
     * Less than or equal       <=
     * Equal to                 ==
     * Not Equal to             !=
     * 
     */


    // Start is called before the first frame update
    void Start()
    {
        print("Hello there");
		
        DoSomething("text input for function to work");
    }

    // Update is called once per frame
    void Update()
    {
		fuelLevel = fuelLevel - 20f;
		print("Current fuel level is " + fuelLevel);

		if (fuelLevel < lowFuelLevel)
		{
			print("Time to refuel!");
		}
    }

    void DoSomething(string theText)
    {
        // Doing something
    }

    string DefineYourself()
    {
        // Think..
        // Contemplate your life..

		// A function which returns anything other than "void" must include a "return" keyword
        return "I'm the Batman";
    }
}
