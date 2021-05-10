using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 6f;
    public Rigidbody2D rb;
    Vector2 movement;
    public GameObject InteractableIcon;
    private Vector2 boxSize = new Vector2(1.5f, 1.5f);
    private bool hasgun = false;
    public Transform firepoint;
    public GameObject GameOver;
    public GameObject player;
    
    

    // Update is called once per frame
    public void MovementSpeed(int n) {
        moveSpeed = (float)n;
    }
    public bool Hasgun() {
        return hasgun;
    }
    public void SetHasgun(bool n) {
        hasgun = n;
    }
    void Update()//handle input here
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            CheckInteraction();
        
        }
        facemouse();
        movement.x =Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("Fire1")&&hasgun) {
            shoot();
        }
        

    }
    private void shoot() {
        RaycastHit2D hitInfo = Physics2D.Raycast(firepoint.position, firepoint.right);
        if (hitInfo) {
            Enemy enemy =hitInfo.transform.GetComponent<Enemy>();
            if (enemy!=null) {
                enemy.TakeDamage(30);
            }
            
        }            
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
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Enemy>().isEnemy()) {
            GameOver.SetActive(true);
            Time.timeScale = 0f;


        }
    }


}
