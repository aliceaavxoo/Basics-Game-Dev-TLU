using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string CarModel = "GTR R35";
    string engineType = "V6, Twin Turbo";
    
    int carWeight = 1609;
    int yearMade = 2009;
    
    float maxAcceleration = 0.98f;
    
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;

void Start()
{
    print("This car is a " + CarModel + " and it is quite powerful, look at the engine " + engineType + ".");

    CheckWeight();

    if (yearMade <= 2009)
    {
        print("The car was introduced in " + yearMade + ".");
        int carAge = CalculateAge (yearMade);

        print("That makes the car " + carAge + " years old.");
    }
    else
    {
        print("The car was introduced in 2010's.");
        print("It's maximum acceleration is " + maxAcceleration + " m/s2.");
    }
   
    print(CheckCharacteristics());

}
 
void CheckWeight()
 {
    if (carWeight < 1500)
    {
    print("The " + CarModel + " weighs less than 1500 kg.");
    }
    else
    {
    print ("The " + CarModel + " weighs more than 1500 kg.");
    }
}

int CalculateAge(int yearMade)
{
return 2023 - yearMade;
}


string CheckCharacteristics()
{
    if (isCarTypeSedan)
    {
    return "The car is a sedan.";
    }
    else if (hasFrontEngine)
    {
    return "The racer is not a sedan, but has a front engine.";
    }
    else
    {
    return "It's not a sedan, nor does it have a front engine.";
    }
}
}