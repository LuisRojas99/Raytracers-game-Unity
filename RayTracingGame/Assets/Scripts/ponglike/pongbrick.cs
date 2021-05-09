using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongbrick : MonoBehaviour
{
    public int brickId;
    private SpriteRenderer sr;
    public Sprite BlackBrick;//4
    public Sprite BlueBrick;//3
    public Sprite RedBrick;//2
    public Sprite WhiteBrick;//1
    public GameObject rb;
    // Start is called before the first frame update
    public void Start() {
        sr = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other ) {

        if (brickId <= 0)
        {
            Destroy(rb);
        }
        else {
            
            brickId--;
            if (brickId == 2) {
                sr.sprite = BlueBrick;
            }
            else if (brickId == 1) {
                sr.sprite = RedBrick;
            }
            else if (brickId== 0) {
                sr.sprite = WhiteBrick;
            }

        }
    }
}
