using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class VRPlayerController : MonoBehaviour
{
    [SerializeField] private InputActionReference jumpActionReference;
    [SerializeField] private float jumpForce = 500.0f;
    [SerializeField] private Transform groundCheckPoint;
    [SerializeField] private LayerMask whatIsGround;

    public CameraShake cameraShake;
    private AudioClip _clip;

    private Rigidbody _body;

    private bool IsGrounded => Physics.OverlapSphere(groundCheckPoint.position, .25f, whatIsGround).Length > 0;
    private bool previousGroundState;

    // Start is called before the first frame update
    void Start()
    {
        _body = GetComponent<Rigidbody>();
        jumpActionReference.action.performed += OnJump; 
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGrounded && !previousGroundState && _body.velocity.y < -20)
        {
            StartCoroutine(cameraShake.Shake(0.15f, 0.4f));
            // AudioSource.PlayClipAtPoint(_clip, transform.position);
        }


    }

    private void OnJump(InputAction.CallbackContext obj)
    {
        if (!IsGrounded) return;
        _body.AddForce(Vector3.up * jumpForce);
    }
}
