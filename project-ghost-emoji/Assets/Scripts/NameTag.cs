using UnityEngine;

public class NameTag : MonoBehaviour
{
    private TMPro.TextMeshPro myTMProComponent;

    public void ModifyText(string myName)
    {
        if (myTMProComponent == null)
            myTMProComponent = GetComponent<TMPro.TextMeshPro>();

        myTMProComponent.text = myName;
    }
}
