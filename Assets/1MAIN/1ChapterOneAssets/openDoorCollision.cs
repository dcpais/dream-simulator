using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoorCollision : MonoBehaviour
{

    public GameObject door;
    public AudioClip clip;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        door.GetComponent<Animation>().Play();
        AudioSource.PlayClipAtPoint(clip, transform.position);
        Destroy(gameObject);
    }
}
