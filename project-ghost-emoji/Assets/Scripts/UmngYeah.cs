using UnityEngine;

public class UmngYeah : MonoBehaviour
{
    public TMPro.TextMeshProUGUI userNameEntry;
    public TMPro.TextMeshProUGUI heightEntry;
    public TMPro.TextMeshProUGUI bioEntry;

    public void UpdateText(string userNames, float heights, string bios)
    {
        userNameEntry.text = userNames;
        heightEntry.text = heights.ToString();
        bioEntry.text = bios;
    }
}
