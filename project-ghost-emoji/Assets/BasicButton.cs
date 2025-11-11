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
        textToChange.text = textEntries[0];
        textToChange.fontSize = newFontSize;


        currentEntry = 4;
    }

    public void Advance()
    {
        
        currentEntry = currentEntry + 1;

        if (currentEntry > 4)
        {
            currentEntry = 0;
        }
        

        textToChange.text = textEntries[currentEntry];


    }

    public void Backwards()
    {

        currentEntry = currentEntry - 1;
        if (currentEntry < 0)
        {
            currentEntry = 4;
        }


        textToChange.text = textEntries[currentEntry];


    }

}
