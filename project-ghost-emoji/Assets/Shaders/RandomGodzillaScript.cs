using UnityEngine;

public class RandomGodzillaScript : MonoBehaviour
{
    private void Start()
    {
        int randomNumber = Random.Range(0, 5);
        if (randomNumber == 3)
            transform.GetChild(0).gameObject.SetActive(true);
    }
}
