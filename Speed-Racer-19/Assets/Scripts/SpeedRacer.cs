using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class SpeedRacer : MonoBehaviour
{
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;
    public string carMaker;
    public string carInfo;
    public Button CheckFuelBtn;
    public Text txtMmy;
    public class Fuel
        {
        public int fuelLevel;
         public Fuel(int amount)
            {
            fuelLevel = amount;
            }
        }
    
    public Fuel carFuel = new Fuel(100);
    
    public void CheckWeight()
    {
         if (carWeight < 1500)
        {
            print("The " + carModel + " weighs less than 1500 kg.");
        }
        else
        {
            print("The " + carModel + " weighs more than 1500 kg.");
        }
    }
    
    public int CalculateAge(int yearMade)
    {
      return 2021-yearMade;
    }

    public string CheckCharacteristics()
    {
      if(isCarTypeSedan)
        {
          return ("The Car type is a sedan");
        }
      else if(hasFrontEngine)
            {
             return ("The Car type is not a sedan but has a front engine");         
             }
      else{
            return ("The car is neither a sedan nor does it have a front engine.");
          }
          
    }

    

    // Start is called before the first frame update
   public void Start()
    {
        // New Code Starts here
            Text txtMy = GameObject.Find ("Canvas/Text").GetComponent<Text>();
            txtMy.text = ("The racer model is " + carModel + " The car maker is" + carMaker + " It has a " + engineType + " engine." + CheckCharacteristics());
            
            txtMmy = GameObject.Find ("Canvas/Fuel").GetComponent<Text>();
         // New Code Ends here
        
        //New Code For Button Starts here
           Button btn = CheckFuelBtn.GetComponent<Button>(); 
           CheckFuelBtn.onClick.AddListener(MoveCar);  

           //txtMmy = GameObject.Find ("Canvas/Fuel").GetComponent<Text>();
           //txtMmy.text = (MoveCar());
            
        
        //New Code For Button Ends here 

       print("The racer model is " + carModel + "The car maker is" + carMaker + ". It has a " + engineType + " engine.");

       CheckWeight();

        if (yearMade <= 2009)
        {
            print("It was first introduced in the year " + yearMade);
            
            int carAge;

            carAge = CalculateAge(yearMade);

            print("That makes the car " + carAge + " years old.");

        } else
        {
            print("It was introduced in the 2010");
            print("And the maximum acceleration is " + maxAcceleration + " miles per second.");
        }

        print(CheckCharacteristics());
        
    }

    public void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }

    public void CheckFuelLevel()
    {
        print(carFuel.fuelLevel);
        
        switch (carFuel.fuelLevel)
        {
            case 70:
                txtMmy.text = "The Fuel level is now nearing two-thirds.";
                break;
            case 50:
                txtMmy.text ="The Fuel level is now at half the amount.";
                break;
            case 10:
               txtMmy.text ="WARNING!!! The Fuel level is now critically low.";
                break;
            default:
               print("Nothing to Report !");
                break;
        }
    }

   public void MoveCar()               //For Button Click
    {
        
        ConsumeFuel();
        CheckFuelLevel();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))    //  (Input.GetKeyDown(KeyCode.Space))
        {
           ConsumeFuel();
           CheckFuelLevel();
        }
    }
    
}
