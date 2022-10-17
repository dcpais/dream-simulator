using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathCollisionTrigger : MonoBehaviour
{

    public GameObject deathBlackout;
    public AudioClip clip;
    public GameObject wind;
    public Transform player;
    public GameObject textlayer;

    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(death());
    }

    public IEnumerator death()
    {
        deathBlackout.SetActive(true);
        textlayer.SetActive(false);
        wind.SetActive(false);
        AudioSource.PlayClipAtPoint(clip, player.position);
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene(3);
    }
}
