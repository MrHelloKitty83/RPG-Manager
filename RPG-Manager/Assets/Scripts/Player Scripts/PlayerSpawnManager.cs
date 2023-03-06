using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSpawnManager : MonoBehaviour
{
    Transform player1Location;
  void OnPlayerJoined(PlayerInput pInput)
    {
        Color[] colors = {Color.white, Color.green, Color.blue, Color.red };
        Debug.Log("Player "+ pInput.playerIndex + " joined.");
        pInput.gameObject.GetComponentInChildren<SpriteRenderer>().color = colors[pInput.playerIndex];
        pInput.gameObject.GetComponentInChildren<PlayerStats>().PlayerID = pInput.playerIndex;
        if(pInput.playerIndex !=0)
        {
            pInput.gameObject.GetComponent<Transform>().position = player1Location.position;
        }
        else
        {
            player1Location = pInput.GetComponent<Transform>(); 
        }
    }
}
