using UnityEngine;

public class GoToProfile : MonoBehaviour
{
    public TMPro.TextMeshProUGUI nameText;
    public string userName;
    public float height;
    public string bio;
    private GameObject screen1;
    private GameObject screen2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Startle()
    {
        screen1.SetActive(false);
        screen2.SetActive(true);
        screen2.GetComponent<UmngYeah>().UpdateText(userName, height, bio);

    }
    public void SetScreensOneAndTwo(GameObject screenOne, GameObject screenTwo)
    {
        screen1 = screenOne;
        screen2 = screenTwo;
    }
    private void Update()
    {
        gameObject.name = userName + "(GameObject)";
        nameText.text = userName;
    }
}
