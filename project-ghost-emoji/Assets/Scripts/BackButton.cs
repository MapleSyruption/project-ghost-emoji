using UnityEngine;
using UnityEngine.Device;

public class BackButton : MonoBehaviour
{
    public GameObject screen1;
    public GameObject screen2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void BackButton_Display () 
    { 
        Debug.Log(screen1);
        //this method turns screen1 off
        Debug.Log("screen1 should be turning on now");
        screen1.SetActive(true);
        if (screen1.activeSelf == true)
        {
            screen2.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
