using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakeOnTrigger : MonoBehaviour
{

    public CameraShake cameraShake;
    public float duration;
    public float mag;

    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(cameraShake.Shake(duration, mag));
    }
}
