using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class captionOnTrigger : MonoBehaviour
{
    public string text;
    public float duration;
    public captionManager manager;

    public void OnTriggerEnter(Collider other)
    {
        manager.createCaption(text, duration);
        Destroy(gameObject, 2);
    }
}
