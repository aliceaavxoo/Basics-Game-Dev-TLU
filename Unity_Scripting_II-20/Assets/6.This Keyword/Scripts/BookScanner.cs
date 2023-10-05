using UnityEngine;
using UnityEngine.UI;

public class BookScanner : MonoBehaviour
{
    public Text titleText;
    public Text ownerText;
    public Text emailText;
    public Text numberText;

    // Start is called before the first frame update
    void Start()
    {
        // Clear out any text at game start
        titleText.text = "";
        ownerText.text = "";
        emailText.text = "";
        numberText.text = "";
    }

    public void ScanBook(Book bookToScan)
    {
        // Fill out the UI texts with information from the scanned book
        titleText.text = bookToScan.bookTitle;
        ownerText.text = bookToScan.bookOwner;
        emailText.text = bookToScan.ownerEmail;
        numberText.text = bookToScan.ownerNum;
    }
}
