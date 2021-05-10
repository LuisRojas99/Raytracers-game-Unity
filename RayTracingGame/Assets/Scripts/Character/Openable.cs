using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(SpriteRenderer))]
public class Openable : Interactable
{
    public Sprite open;
    public Sprite closed;
    public int ChestId;
    private SpriteRenderer sr;
    private bool isOpen;
    
    
    private void Start() {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = closed;
    }


    public override void Interact() {

        if (isOpen)
        {
            sr.sprite = closed;

        }
        else {
            sr.sprite = open;
            

                SceneManager.LoadScene(ChestId);//2 for sudoku  3 for ponglike
            

        }
        isOpen = !isOpen;
    }

}
