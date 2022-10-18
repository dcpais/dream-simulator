using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VRPlayerController : MonoBehaviour
{
    public InputActionReference jumpActionReference;
    public float groundDist;
    public LayerMask whatIsGround;
    public Transform groundCheck;

    public float speed;
    public float jumpHeight;
    public float gravity;

    public GameObject footsteps;

    public CameraShake cameraShake;

    public CharacterController controller;

    Vector3 velocity;

    bool previousGroundedState;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {

        jumpActionReference.action.performed += OnJump; 
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDist, whatIsGround);

        if (!previousGroundedState && isGrounded && velocity.y < -25)
        {
            StartCoroutine(cameraShake.Shake(.4f, .6f));
        }

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; 
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        previousGroundedState = isGrounded;
    }

    private void OnJump(InputAction.CallbackContext obj)
    {
        if (!isGrounded)
        {
            return;
        }
    }
}
