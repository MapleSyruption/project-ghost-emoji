using UnityEngine;

public class FrontDoor : MonoBehaviour
{
    public GameObject personPrefab;
    public float waitTimeBeforeSpawning;
    private float timeElapsed;

    private void Start()
    {
        timeElapsed = 0f;
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > waitTimeBeforeSpawning)
        {
            SpawnAPerson();
        }
       

    }

    void SpawnAPerson()
    {
        GameObject personToSpawn = Instantiate(personPrefab, this.transform);
        personToSpawn.transform.parent = null;
        personToSpawn.transform.localScale = new Vector3(.5f, .5f, .5f);
    }
}
