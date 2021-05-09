using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 5f;
    private int pongLives = 3;
    public GameObject gameOver;
    void Start()
    {
        pongLives= 3;
        gameOver.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Respawn() {
        transform.position = Vector2.zero;
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;
        pongLives--;
        if (pongLives<=0) {
            OutOfLives();    
        
        }
    
    }
    private void OutOfLives()
    {

            gameOver.SetActive(true);
           
        
    }

}
