using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    public float speed = 5f;
    private float input;
    void Start() { }
    void Update() {
        input = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate() {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * input * speed;
    }

}
