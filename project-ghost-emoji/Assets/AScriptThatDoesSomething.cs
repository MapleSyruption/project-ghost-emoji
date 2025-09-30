using UnityEngine;

public class AScriptThatDoesSomething : MonoBehaviour
{

    public bool isBlue;
    public TMPro.TextMeshPro text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // I want the text to start red,
        // so I set "isBlue" to false
        isBlue = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isBlue == false)
        {
            text.color = Color.blue;
        } else
        {
            text.color = Color.red;
        }
        
    }
}
