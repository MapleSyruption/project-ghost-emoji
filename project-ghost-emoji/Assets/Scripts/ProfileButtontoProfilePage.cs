using UnityEngine;
using UnityEngine.Device;

public class ProfileButtontoProfilePage : MonoBehaviour
{
    public GameObject screen1;
    public GameObject screen2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void BackButton_Display()
    {
        Debug.Log(screen1);
        //this method turns screen1 on
        Debug.LogError("screen1 should be turning on now - start");
        screen1.SetActive(false);
        screen2.SetActive(true);
        Debug.Log(screen1);
        //this method turns screen1 on
        Debug.LogError("screen1 should be turning on now - end");
    }
}
