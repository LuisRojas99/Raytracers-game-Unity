using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    private float distance;
    RaycastHit2D infoRay;
    public Rigidbody2D rb;
    public Rigidbody2D rb2;

    // Start is called before the first frame update
    void Start()
    {
        distance = .3f;
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(rb2.transform.position.x - rb.transform.position.x ,rb2.transform.position.y- rb.transform.position.y );

        infoRay = Physics2D.Raycast(rb.transform.position, direction);

        Debug.DrawRay(rb.transform.position, direction , Color.blue);

        distance = Mathf.Sqrt(Mathf.Abs(rb.transform.position.x - rb2.transform.position.x) + Mathf.Abs(rb.transform.position.y - rb2.transform.position.y));
        
        
    }
}
