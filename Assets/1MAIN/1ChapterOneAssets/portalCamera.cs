using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalCamera : MonoBehaviour
{

    public Transform playerCamera;
    public Transform portal;
    public Transform otherPortal;


    // Update is called once per frame
    void Update()
    {
        Vector3 playerOffsetfromPortal = playerCamera.position - otherPortal.position;
        transform.position = portal.position + playerOffsetfromPortal;

        float angularDifference = Quaternion.Angle(portal.rotation, otherPortal.rotation);
        Quaternion portalRotationDifference = Quaternion.AngleAxis(angularDifference, Vector3.up);
        Vector3 newCameraDirection = portalRotationDifference * playerCamera.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
    }
}
