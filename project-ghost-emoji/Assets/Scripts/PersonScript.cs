using UnityEngine;

public class PersonScript : MonoBehaviour
{
    public GameObject myNameTag;

    private string myFullName;
    private float walkingSpeed;

    void Start()
    {
        DoTheThingIWantYouToDo();
    }

    private void Update()
    {
        DoAnotherThingIfImBeingHonest();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PersonScript>() == null)
        {
            Debug.LogError("Whatever I just collided with did not have a PersonScript on it. That object is called " + collision.gameObject.name);
            return;
        }
        
        PersonScript friendIHaveBumpedInto = collision.gameObject.GetComponent<PersonScript>();
        Debug.Log(myFullName + " just bumped into " + friendIHaveBumpedInto.GetSomeRandomInformationIDKReally());

    }












    /// <summary>
    /// rename this script once you understand what it does.
    /// Whatever feels most accurate please.
    /// </summary>
    private void DoTheThingIWantYouToDo()
    {
        int randomNumber = Random.Range(0, 6);

        if (randomNumber == 0)
        {
            myFullName = "Yellow Yasmine";
            myNameTag.GetComponent<NameTag>().ModifyText(myFullName);
        }
        else if (randomNumber == 1)
        {
            myFullName = "Red Randy";
            myNameTag.GetComponent<NameTag>().ModifyText(myFullName);
        }
        else if (randomNumber == 2)
        {
            myFullName = "Blue Bart";
            myNameTag.GetComponent<NameTag>().ModifyText(myFullName);

        }
        else if (randomNumber == 3)
        {
            myFullName = "Green Gump";
            myNameTag.GetComponent<NameTag>().ModifyText(myFullName);
        }
        else if (randomNumber == 4)
        {
            myFullName = "Orange Angie";
            myNameTag.GetComponent<NameTag>().ModifyText(myFullName);

        }
        else if (randomNumber == 5)
        {
            myFullName = "Purple Paul";
            myNameTag.GetComponent<NameTag>().ModifyText(myFullName);
        }

        float randomWalkingSpeed = Random.Range(1f, 10f);
        walkingSpeed = randomWalkingSpeed;
    }


    /// <summary>
    /// rename this script once you understand what it does.
    /// Whatever feels most accurate please.
    /// </summary>
    void DoAnotherThingIfImBeingHonest()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 0), walkingSpeed / 600f);

        if (Vector3.Distance(transform.position, new Vector3(0, 0, 0)) < .7f)
        {
            Destroy(this.gameObject);
        }
    }


    /// <summary>
    /// rename this script once you understand what it does.
    /// Whatever feels most accurate please.
    /// </summary>
    public string GetSomeRandomInformationIDKReally()
    {
        return myFullName;
    }
}
