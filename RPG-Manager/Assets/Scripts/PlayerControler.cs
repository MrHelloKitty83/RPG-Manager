using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{

    public LayerMask interactLayerMask;
    public Rigidbody2D rig;
    public SpriteRenderer sr;

    public float moveSpeed;

    private Vector2 moveInput;
    private bool interactInput;

    private Vector2 facingDir;


    private void Update()
    {
        if (moveInput.magnitude !=0.0f)
        {
            facingDir = moveInput.normalized;
            sr.flipX = moveInput.normalized.x > 0;
        }    
    }
    private void FixedUpdate()
    {
        rig.velocity = moveInput.normalized * moveSpeed * Time.deltaTime;
    }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void OnInteractInput(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed)
        {
            interactInput = true;
        }
    }

}
