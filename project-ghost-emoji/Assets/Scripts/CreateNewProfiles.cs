using UnityEngine;

public class CreateNewProfiles : MonoBehaviour
{
    public GameObject Profile1;
    public GameObject Screen1;
    public GameObject Screen2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Profile1);
        //this script creates new profiles
        Debug.Log("why isnt this button creating a new profile");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateNewProfileFromPrefab()
    {
        Debug.Log(Profile1);
        //this script creates new profiles
        Debug.Log("really why");

    
       GameObject profilePrefab=Object.Instantiate(Profile1, ProfileGrouping.transform);
       ProfileButtontoProfilePage newUser= profilePrefab.GetComponent<ProfileButtontoProfilePage>();
        newUser.SetSpecificScreen(Screen1, Screen2);

    }

    public GameObject ProfileGrouping;
    

}