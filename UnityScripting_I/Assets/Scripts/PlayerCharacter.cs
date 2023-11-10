using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// The class name (PlayerCharacter) must match the file name in Unity project folder
public class PlayerCharacter : MonoBehaviour
{
    // This is a single line comment. It starts with //

    /*
     * This is a multi-line comment.
     * Anything between the start and end markers is considered a comment regardless of how many lines there are.
     * It starts with /* and ends with */
     
    
    /*
     * The most common variable data types are:
     * string   - for storing text
     * int      - for integer values (negative and positive). Doesn't accept numbers with decimal places
     * float    - for values with decimal numbers (also -ve & +ve). Must add an "f" after the number like so 1.5f
     * bool     - for values that can only be yes/no, on/off, etc. Boolean variables only accept "true" & "false" values
     */


    /* 
     * Declaring a variable to store data:
     *   public          - So we can see the variable in Unity's inspector window
     *   
     *   string/int/etc. - Define what's the type of data stored in the variable
     *   
     *   playerName      - The name we give to our variable to grab it from anywhere in our code (note the first letter in variable names is small)
     *   
     *   = "Fran"        - We assign an initial value to our variable. Assigning a value on the same line we declare a variable is called "initialising" the variable
     *   
     *   
     *   IMPORTANT: Variable names have to be unique from each other. We cannot declare two variables using the same name, even if
     *              they have a different data type.
     *              C# language keywords cannot be used for variable names. E.g. public, class, float, return.
     *   
     *   The variables `playerName`, `playerAge`, `playerWeight`, and `hasKey` exist in the class' body and can be accessed 
     *   from any function in this class (and other code files). Variables that are accessible from anywhere like so are called "global variables".
     */

    public string playerName = "Fran";


    public int playerAge = 32;

    public float playerWeight = 74.28f;

    // As bool variable values can only be true or false, we name them in the style of a yes/no question.
    // e.g. isAwake, hasArrived, canJump, didMove, etc.
    public bool hasKey = false;


    // Start executes once and is called before the first frame update
    void Start()
    {
        // We execute/call a function by typing its name and adding parentheses
        SayHello();
        SayBye();
        CheckPlayerHasKey();


        // We call a function that requires arguments/inputs by typing its
        // name and providing the arguments between the parentheses (just like `print` function)
        AddToPlayerAge(2);


        // Some functions return values when called, which can be stored in variables.
        // More about this below.
        float playerHalfWeight = GetHalfPlayerWeight();

        // We can mix strings with variables using the `+`
        print("Half of the weight of " + playerName + " is: " + playerHalfWeight);
    }

    // Update is called once per frame
    void Update()
    {
        // Whatever we write here will be constantly executed while the game's running
        // Typically used to check for player input in the keyboard, mouse, controller, etc.
        // Also used to move objects around the world
    }


    /*
     * Declaring a function:
     *  void - this tells what data the function will "return" to whoever calls it. "void" means the function will just execute without giving back any data
     *  
     *  SayHello - the name we give to our function, so we can call it elsewhere from our code (note the first letter in function names is capital)
     *  
     *  () - the parentheses contain what is called "function arguments", which is any additional data the function may need to be able to do its job.
     *       Empty parentheses like here means the function doesn't need any arguments/inputs to work
     *  
     *  {...} - anything between the 2 curly braces marks the contents of the function
     */
    void SayHello()
    {
        /* 
         * "print" is a Unity function. It cannot be called like so `print()`, because print
         * requires an argument/input, which in this case the argument is what it will display in the console window.
         * We provide the argument between the parentheses ( )
         * 
         * Try writing `print();` to call it without any arguments. Visual Studio will show an error red line.
         * Hovering over the error will tell you that an argument is missing for the function.
         */
        print("Oh hi " + playerName);
    }


    void SayBye()
    {
        /*
         * `byeMessage` below is a "local variable". Local variables only exist in the body of their function and cannot be accessed
         * anywhere outside of it. They're the opposite of global variables (such as `playerName` above).
         * Try typing `byeMessage` somewhere else, you'll get an error.
         * 
         * This is useful to store data for use ONLY in this function and nowhere else, so we don't want it to be globally accessible
         * from anywhere else to avoid mistakes.
         * 
         * Local variables are useful when we want to break down a complex step (like several math calculations) into 
         * smaller pieces which are easier to read and understand. They also make that piece reusable in several places
         * inside of their function, instead of repeating the same code multiple times; just like normal variables.
         * 
         * When declaring a local variable we don't add `public` before the data type. This is because local variables are inherently 
         * limited to their function and can never be seen or used elsewhere (public).
         */

        string byeMessage = "Bye " + playerName;

        print(byeMessage);
    }


    /*
     * Unlike the other functions, `AddToPlayerAge` requires an input to work: What to add to the player's age?
     * 
     * Function inputs are called "arguments". We define them by giving them a type (`int` in this case), and
     * a name (`numberToAdd` in this case).
     * 
     * They're essentially just like declaring a local variable, but this way we tell whoever wants to use
     * the function that they need to provide it with what it's asking for first.
     * 
     * Functions can have as many arguments as we want. We separate each argument using a comma `,`
     * e.g.: void CreateName(string firstName, string lastName)
     * 
     * Typically, a function shouldn't have more than 3-4 arguments. If we find that it needs more,
     * chances are it's better to split it into 2 or more smaller functions with less arguments.
     */
    void AddToPlayerAge(int numberToAdd)
    {
        print("Adding " + numberToAdd + " to player's age.");
        
        int result = playerAge + numberToAdd;

        print("The result is: " + result);
    }


    /*
     * `GetHalfPlayerWeight` is different from the other functions in that it starts with `float`
     * instead of `void`. This means that it will not only execute, but is also expected to "return" (or give back)
     * something before it's considered done - in this case it will return a value of type float (a number with decimals).
     * 
     * The types of data a function can return are the same as the types we use for variables:
     * string, int, float, bool, etc.
     */
    float GetHalfPlayerWeight()
    {
        // Divide the player's weight by 2 (we add `f` because we're dealing with float types, not int)
        float halfWeight = playerWeight / 2f;

        /*
         * Since the function must return a value before completion, we type `return` keyword and then
         * the value to give back. In this case, the function is to return a value of type float, and the variable
         * `halfWeight` is also of the same type, hence it's acceptable to return whatever value is stored in it.
         * 
         * Try removing the below code line. Visual Studio will show an error on the function name; 
         * stating that it's not returning a value.
         */
        return halfWeight;

        // `return "hello"` or `return true` will give errors becuase they're the wrong data type
    }


    // This function combines everything from the above
    // Try using it in Start() above like the other functions and print the returned value to Unity's console
    int AddTwoNumbers(int firstNumber, int secondNumber)
    {
        int result = firstNumber + secondNumber;
        return result;
    }


    void CheckPlayerHasKey()
    {
        /*
         * A key part of programming is decision-making based on data. To make a decision, we use "if statements" like below.
         * 
         * The condition to decide on must be something that evaluates to either `true` or `false`.
         * In this case, `hasKey` is a boolean type variable and already contains either one of these two values.
         * 
         * We write `if` and between parentheses the condition to evaluate: in this case the value stored in `hasKey`
         * variable will be evaluated. If it evaluates to true, whatever code between the two braces
         * below the `if` will execute, and the code between the two braces below the `else` will be ignored.
         * 
         * If it evaluates to false, the opposite happens: the code section (or "block") belonging to `if` is ignored,
         * and the block belonging to `else` is executed.
         */


        // If the player has the key, say they do. Otherwise, say they don't have the key.
        if (hasKey)
        {
            print(playerName + " has the key!");
        }
        else
        {
            print(playerName + " doesn't have the key :(");
        }
    }
}