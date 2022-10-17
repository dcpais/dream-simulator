using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject, 2);
    }
}
