using UnityEngine;

public class BasicButton : MonoBehaviour
{
    public string textone; public TMPro.TextMeshPro textToChange;
    public void Display ()
    {
        Debug.Log("it got this far"+ textToChange.text);
        textToChange.text = textone;
        Debug.Log("it got even farther"+ textToChange.text);
    }




    // This is a new method made for the field trip
    public int newFontSize;
    public string[] textEntries; 
    public int currentEntry;

    
    private void Start()
    {
        textToChange.text = textEntries[4];
        textToChange.fontSize = newFontSize;
    }

    public void Advance()
    {

        currentEntry = currentEntry - 1;
        

        textToChange.text = textEntries[currentEntry];


    }
    
}
