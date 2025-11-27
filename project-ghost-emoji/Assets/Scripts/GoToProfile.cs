using UnityEngine;

public class GoToProfile : MonoBehaviour
{
    public GameObject screen1;
    public GameObject screen2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(screen1);
        //this method turns screen1 off
        Debug.Log("screen1 should be turning off now");
        screen1.SetActive(false);
        if (screen1.activeSelf == false) 
        { screen2.SetActive(true); 
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
