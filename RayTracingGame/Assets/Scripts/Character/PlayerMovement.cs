using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public GameObject InteractableIcon;
    private Vector2 boxSize = new Vector2(1.5f, 1.5f);
    
    

    
    // Update is called once per frame
    void Update()//handle input here
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            CheckInteraction();
        
        }
        facemouse();
        movement.x =Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        

    }
    void FixedUpdate() { //handle movement here
        rb.MovePosition(rb.position + movement * moveSpeed* Time.fixedDeltaTime);
    
    }
    void facemouse() {

        Vector2 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(mousePosition.x -transform.position.x, mousePosition.y - transform.position.y);
        transform.up = direction;
    
    }

    
    
    public void OpenInteractableIcon() {
        InteractableIcon.SetActive(true);
    
    }
    public void CloseInteractableIcon()
    {
        InteractableIcon.SetActive(false);

    }
    private void CheckInteraction() {
        RaycastHit2D[] Hits = Physics2D.BoxCastAll(transform.position,boxSize,0,Vector2.zero);
        if (Hits.Length > 0) {
            foreach (RaycastHit2D rc in Hits) {
                if (rc.transform.GetComponent<Interactable>()) {
                    rc.transform.GetComponent<Interactable>().Interact();
                    return;
                }
            }
        }
        
    }


}
