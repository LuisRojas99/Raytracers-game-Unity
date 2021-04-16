using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    private IInteractable interactable;

    public float distance;
    RaycastHit2D infoRay;
    public GameObject chestIn;

    // Update is called once per frame
    void Update()//handle input here
    {
        facemouse();
        movement.x =Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        infoRay = Physics2D.Raycast(rb.transform.position, Vector2.down, distance);
        Debug.DrawRay(rb.transform.position, Vector2.down * distance, Color.blue);
        if (infoRay.collider.name == "Chest") {
            chestIn.SetActive(true);
        }

    }
    void FixedUpdate() { //handle movement here
        rb.MovePosition(rb.position + movement * moveSpeed* Time.fixedDeltaTime);
    
    }
    void facemouse() {

        Vector2 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(-mousePosition.x +transform.position.x, -mousePosition.y + transform.position.y);
        transform.up = direction;
    
    }

    public void Interact() {
        if (interactable != null) {
            interactable.Interact();
        
        } 
        
    }
    public void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Interactable") {
            interactable = collision.GetComponent<IInteractable>();
        }
    
    }
    public void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Interactable")
        {
            if (interactable != null)
            {
                interactable.StopInteract();
                interactable = null;
            }
        }

    }



}
