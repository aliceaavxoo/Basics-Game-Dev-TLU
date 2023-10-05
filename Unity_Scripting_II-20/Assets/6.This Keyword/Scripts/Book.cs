using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public string bookTitle = "Architecture & Roofs";
    public string bookOwner;
    public string ownerEmail;
    public string ownerNum;

    public BookScanner scanner;

    public void SendToScanner()
    {
        // Provide the scanner with an instance of Book
        scanner.ScanBook(this);
    }
}
