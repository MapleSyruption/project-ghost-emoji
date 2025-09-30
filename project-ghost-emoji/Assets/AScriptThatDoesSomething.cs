using UnityEngine;

public class AScriptThatDoesSomething : MonoBehaviour
{

    public bool isBlue;
    public TMPro.TextMeshPro text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        isBlue = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isBlue)
        {
            text.color = Color.blue;
            

        } else
        {
            text.color = Color.red;
        }
        
    }
}
