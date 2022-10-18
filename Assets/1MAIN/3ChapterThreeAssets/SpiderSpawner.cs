using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderSpawner : MonoBehaviour
{
    [SerializeField] private GameObject swarmerPrefab;
    [SerializeField] private float swarmerInterval = 3.5f;
    public Transform playerTracker;
    private int count = 0;

    void Start()
    {
        StartCoroutine(spawnSpider(swarmerInterval, swarmerPrefab));
    }

    private IEnumerator spawnSpider(float interval, GameObject spider) 
    {
        yield return new WaitForSeconds(interval);
        if (Vector3.Distance(this.transform.position, playerTracker.position) < 50.0f) 
        {
            Vector3 spawnPos = new Vector3(transform.position.x, 0, transform.position.z);
            Instantiate(spider, spawnPos, Quaternion.identity);
            count += 1;
        }

        if (count > 15)
        {
            yield return null;
        }
        else {
            StartCoroutine(spawnSpider(interval, spider));
        }
        
    }

}
