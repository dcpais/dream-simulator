using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderSpawner : MonoBehaviour
{
    [SerializeField] private GameObject swarmerPrefab;
    [SerializeField] private float swarmerInterval = 3.5f;

    void Start()
    {
        StartCoroutine(spawnSpider(swarmerInterval, swarmerPrefab));
    }

    private IEnumerator spawnSpider(float interval, GameObject spider) 
    {
        yield return new WaitForSeconds(interval);
        GameObject newSpider = Instantiate(spider, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnSpider(interval, spider));
    }

}
