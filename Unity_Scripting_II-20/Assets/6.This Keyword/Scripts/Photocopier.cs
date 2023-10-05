using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Photocopier : MonoBehaviour
{
    // These are arrays, defined as such by adding the '[]' square brackets after the data type
    public GameObject[] availableBookCopies;
    public GameObject[] scanButtons;

    private int copyCount = 0;

    void Start()
    {
        // Hide (and make inactive) all the book copies and scan buttons at the start of the game
        for (int i = 0; i < availableBookCopies.Length; i++)
        {
            availableBookCopies[i].SetActive(false);
            scanButtons[i].SetActive(false);
        }
    }

    public void MakeACopy()
    {
        /* If all book copies are created (meaning that the copyCount variable value is higher than the number of elements in
         * the availableBookCopies array variable) then skip making more copies.
         * This is achieved by calling 'return' inside the if code block, which will exit the function MakeACopy() early
         * and thus not execute the code after the if block (the part that makes the copies).
         */
        // N.B.: If this if statement and its block were commented out, we'd get an error
        // due to the number of available copies being less than copyCount... Try out yourself!
        if (copyCount >= availableBookCopies.Length)
        {
            print("no more available copies to make");
            return;
        }

        /* Below we can access a specific element of the array using the copyCount variable,
         * because copyCount is in the end a variable that holds a number. And array elements are accessed
         * by typing the array variable name and then followed by the index number of the element in square brackets
         */
        availableBookCopies[copyCount].SetActive(true);
        scanButtons[copyCount].SetActive(true);

        // Increment copyCount by 1 in order to access the next element in the array when MakeACopy() is called again
        copyCount++;
    }
}
