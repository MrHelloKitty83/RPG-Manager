using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldTile : MonoBehaviour
{
    //private Crop curCrop;
    public GameObject cropPrefab;
    public SpriteRenderer sr;

    private bool tilled;

    [Header("Sprites")]
    public Sprite grassSprite;
    public Sprite tilledSprite;
    public Sprite wateredTilledSprite;

    private void Start()
    {
        //Set Default Grass Sprite
        sr.sprite = grassSprite;
    }
    public void Interact ()
    {
        gameObject.SetActive(false);
        Debug.Log("Interacted!");
    }
}
