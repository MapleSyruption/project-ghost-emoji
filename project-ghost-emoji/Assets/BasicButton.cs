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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
