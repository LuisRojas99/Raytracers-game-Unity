using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestScript : MonoBehaviour, IInteractable
{
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private Sprite openSprite;
    private Sprite closedSprite;
        private bool isOpen;
    public Rigidbody2D rb;
    


    void Update()//handle input here
    {
        Vector2 mousePosition = Input.mousePosition;
        if (mousePosition.x >= rb.transform.position.x-24&& mousePosition.x <= rb.transform.position.x + 24 && mousePosition.y >= rb.transform.position.y - 24&& mousePosition.y <= rb.transform.position.y + 24) {
            if (Input.GetButtonDown("Fire1")) {
                SceneManager.LoadScene(2);

            }
        
        }
    
    }


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
