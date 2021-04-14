﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour, IInteractable
{
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private Sprite openSprite;
    private Sprite closedSprite;
        private bool isOpen;

    public void Interact() {

        if (isOpen)
        {
            StopInteract();

        }
        else {
            isOpen = true;
            spriteRenderer.sprite = openSprite;
        }
    }
    public void StopInteract() { 
    
    }
}