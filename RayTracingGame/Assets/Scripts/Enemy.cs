using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Life = 10;
    public GameObject enemy;
    public GameObject player;
    private Rigidbody2D rb;
    private Vector2 movement;
    private float moveSpeed=5f;

    void Start() {
        rb = this.GetComponent<Rigidbody2D>();
    
    }
    void Update()
    {
        Vector2 direction = player.transform.position - enemy.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; ;
        rb.rotation = angle-90;
        direction.Normalize();
        movement = direction;
        if (Life <= 0)
        {
            Destroy(enemy);
        }

    }
    void FixedUpdate() {
        moveEnemy(movement);

    }
    void moveEnemy(Vector2 direction) {
        rb.MovePosition((Vector2)transform.position + (direction* moveSpeed * Time.deltaTime));
    
    }
    public bool isEnemy() {
        return true;
    }
    public void TakeDamage(int n)
    {
        Life = Life - n;

    }
}
