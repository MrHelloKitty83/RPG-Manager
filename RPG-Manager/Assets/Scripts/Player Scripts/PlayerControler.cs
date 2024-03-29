using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

public class PlayerControler : MonoBehaviour
{

    public LayerMask interactLayerMask;
    public Rigidbody2D rig;
    public SpriteRenderer sr;
    public PlayerInput playerInput;

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
        if(interactInput)
        {
            TryInteractTile(); 
            interactInput= false;
        }
    }
    private void FixedUpdate()
    {
        rig.velocity = moveInput.normalized * moveSpeed * Time.deltaTime;
    }

    void TryInteractTile ()
    {
        RaycastHit2D hit = Physics2D.Raycast((Vector2)transform.position + facingDir, Vector3.up, 0.1f, interactLayerMask);//Fire at tile in front of player
        
        if(hit.collider != null)
        {
            IInteractable tile = hit.collider.GetComponent<IInteractable>();
            tile.Interact(gameObject.GetComponent<PlayerStats>());
        }
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
    public void OnMenuInput(InputAction.CallbackContext context)
    {
            Debug.Log("Menu Input!");
    }

    internal void SwitchCurrentActionMap(string newMap)
    {
        Debug.Log("Switching Current Actio Map to: " + newMap);
        playerInput.SwitchCurrentActionMap(newMap);
    }
}
