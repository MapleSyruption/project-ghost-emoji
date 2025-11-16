using UnityEngine;

public class UserEntry : MonoBehaviour
{
    public string userName;
    private string password;
    public TMPro.TextMeshProUGUI userNameTextEntry;
    public ScreenManager myScreenManager;
    public void DisplayUserInfo()
    {
        userNameTextEntry.text = userName;
    }
    public void SelectUser()
    {
        myScreenManager.DisplayOtherOne(this);
    }
}
