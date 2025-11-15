using UnityEngine;

public class NameTag : MonoBehaviour
{
    private TMPro.TextMeshPro myTMProComponent;

    public void SetText(string myName, Color myColor)
    {
        if (myTMProComponent == null)
            myTMProComponent = GetComponent<TMPro.TextMeshPro>();

        myTMProComponent.text = myName;
        myTMProComponent.color = myColor;
    }
}
