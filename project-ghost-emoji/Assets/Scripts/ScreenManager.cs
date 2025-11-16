using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public GameObject allProfilesPage;
    public GameObject specificProfilePage;
    public GameObject userPrefab;
    public GameObject userContent;

    private void Start()
    {
        ReturnToHomePage();
    }

    public void CreateUser(string typedText)
    {
        var editingUser = Instantiate(userPrefab, userContent.transform);
        editingUser.GetComponent<UserEntry>().userName = typedText;
        editingUser.GetComponent<UserEntry>().myScreenManager = this;
        editingUser.GetComponent<UserEntry>().DisplayUserInfo();
    }
    public void DisplayOtherOne(UserEntry userEntry)
    {
        allProfilesPage.SetActive(false);
        specificProfilePage.SetActive(true);
        // populate specific Profile Page with user Entry
    }

    public void ReturnToHomePage()
    {
        allProfilesPage.SetActive(true);
        specificProfilePage.SetActive(false);
    }
}
