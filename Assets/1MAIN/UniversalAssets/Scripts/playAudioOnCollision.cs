using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnCollision : MonoBehaviour
{
    [SerializeField]
    private AudioClip _clip;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.CompareTag("Player"))
        {

            AudioSource.PlayClipAtPoint(_clip, transform.position);
            Destroy(gameObject);
        }
    }
}
