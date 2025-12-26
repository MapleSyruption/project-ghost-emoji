using UnityEngine;

public class FrontDoor : MonoBehaviour
{
    public GameObject personPrefab;
    public float waitTimeBeforeSpawning;
    public float timeElapsed;

    public void SpawnAPerson()
    {
        GameObject personToSpawn = Instantiate(personPrefab, transform);
        personToSpawn.transform.parent = null;
        personToSpawn.transform.localScale = new Vector3(.5f, .5f, .5f);
        timeElapsed = 0f;
    }

    public void Update()
    {
        timeElapsed = timeElapsed + Time.deltaTime;

        if (timeElapsed > waitTimeBeforeSpawning)
        {
            SpawnAPerson();
        }

    }
}
