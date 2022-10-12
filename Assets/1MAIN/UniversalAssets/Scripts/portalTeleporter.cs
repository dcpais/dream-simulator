using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalTeleporter : MonoBehaviour
{

    public Transform player;
    public Transform reciever;

    private bool playerOverlapping = false;

    // Update is called once per frame
    void Update()
    {
        Vector3 portalToPlayer = player.position - transform.position;
        float dotProduct = Vector3.Dot(transform.up, portalToPlayer);

        // If true, we will teleport the player to the other portal
        if (dotProduct < 0f)
        {
            float rotationDiff = Quaternion.Angle(transform.rotation, reciever.rotation);
            rotationDiff += 180;
            player.Rotate(Vector3.up, rotationDiff);

            Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
            player.position = reciever.position + positionOffset;

            playerOverlapping = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        { 
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {

        }
    }

}

