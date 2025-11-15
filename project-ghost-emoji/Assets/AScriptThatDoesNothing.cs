using UnityEngine;

public class AScriptThatDoesNothing : MonoBehaviour
{
    public string moreofwhateverIwant ; 

    public bool mostofwhateverIwant; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {Debug.Log(moreofwhateverIwant);
        // This code does nothing
        // EXCEPT for printing a line to the console
        Debug.Log("This is a harmless line of code");
        
    }

    // Update is called once per frame
    void Update()
    {
     if (mostofwhateverIwant == true) {
            Debug.Log("whatever I want");
            Debug.Log(moreofwhateverIwant);

     }  
   

        
    }
}
