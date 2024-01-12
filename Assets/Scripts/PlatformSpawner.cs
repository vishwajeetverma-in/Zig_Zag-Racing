using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public Transform lastPlatform;
    Vector3 lastPosition;
    Vector3 newPos;
    bool stop;
    private void Start()
    {
        lastPosition = lastPlatform.position;
        StartCoroutine(SpawnPlatforms());
        
    }

    private void Update()
    {
      
    }

    IEnumerator SpawnPlatforms()
    {
        while (!stop)
        {
            GeneratePosition();
            Instantiate(platformPrefab, newPos, Quaternion.identity);
            lastPosition = newPos;
            yield return new WaitForSeconds(0.1f);
        }
      
    }

    

    void GeneratePosition()
    {
        newPos = lastPosition;
        int rand = Random.Range(0, 2);
        if (rand > 0)
        {
            newPos.x += 2f;
        }
        else
        {
            newPos.z += 2f;
        }
    }
}
