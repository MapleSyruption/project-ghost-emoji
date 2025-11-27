using UnityEngine;

public class CreateNewProfiles : MonoBehaviour
{
    public GameObject Profile1;
    public GameObject screenOne;
    public GameObject screenTwo;

    public void CreateNewProfileFromPrefab()
    {

        var newProfile = Instantiate(Profile1, ProfileGrouping.transform);
        newProfile.GetComponent<GoToProfile>().SetScreensOneAndTwo(screenOne, screenTwo);
    
    }

    public GameObject ProfileGrouping;
    

}