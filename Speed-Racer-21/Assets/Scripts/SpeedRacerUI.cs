using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeedRacerUI : MonoBehaviour
{
    public class Fuel
    {
        public int fuelLevel = 0;
        
        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }

    public  Fuel carFuel = new Fuel(100);
    
    public string CarModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public string carMaker = " ";
    
    public int carWeight = 1609;
    public int yearMade = 2009;

    public float maxAcceleration = 0.98f;
    
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    public TextMeshProUGUI UIText;

void Start()
{
    print("This car is a " + CarModel + " from the " + carMaker + " factory, and it is quite powerful, look at the engine: " + engineType + ".");

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

public void SayHello() {
    UIText.text = "Car model: " + CarModel;
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

void Update()
{

}

public void ConsumeAndCheckFuel() {
    ConsumeFuel();
    CheckFuelLevel();
}

void ConsumeFuel()
{
    carFuel.fuelLevel = carFuel.fuelLevel -10;
}

void CheckFuelLevel()
{
    switch (carFuel.fuelLevel)
    {
        case 70:
            UIText.text = "The fuel level is nearing two-thirds.";
            break;
        case 50:
            UIText.text = "The fuel level is at half amount.";
            break;
        case 10:
            UIText.text = "Warning! The fuel level is critically low.";
            break;
        case 0:
            UIText.text = "The car has stopped, call for help!";
            break;
        default:
            UIText.text = "Nothing to report.";
            break;
    } 
}
    
}