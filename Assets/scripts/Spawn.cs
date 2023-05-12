using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject PowerUpPrefab;
    public float spawnCycle = 0.5f;
    private float timeElapsed = 0;
    private bool spawnPowerUp = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed> spawnCycle)
        {
            GameObject temp; if (spawnPowerUp)
            {
                temp = Instantiate(PowerUpPrefab) as GameObject;
                Vector3 pos = temp.transform.position;
                temp.transform.position = new Vector3(Random.Range(-3, 4), pos.y, pos.z);
            }
            else
            {
                temp = Instantiate(obstaclePrefab) as GameObject;
                Vector3 pos = temp.transform.position;
                temp.transform.position = new Vector3(Random.Range(-3, 4), pos.y, pos.z);
            }
            timeElapsed -= spawnCycle;
            spawnPowerUp = !spawnPowerUp;
        }
    }
}
