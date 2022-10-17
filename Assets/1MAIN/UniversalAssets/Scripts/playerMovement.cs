using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public CharacterController controller;
    public CameraShake cameraShake;

    public float speed = 12f;
    public float gravity = -19.6f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
	bool isGrounded;
    bool previousGroundedState;

    public GameObject footsteps;

	// Start is called before the first frame update
	void Start()
    {
        footsteps.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (!previousGroundedState && isGrounded && velocity.y < -25)
        {
            StartCoroutine(cameraShake.Shake(.4f, .6f));
        }

        if (isGrounded && velocity.y < 0) {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        Vector3 move = transform.right * x + transform.forward * z;

        if (move != new Vector3(0, 0, 0) && isGrounded)
        {
            footsteps.SetActive(true);
        }
        else 
        {
            footsteps.SetActive(false);
        }

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded) {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        previousGroundedState = isGrounded;
    }
}
