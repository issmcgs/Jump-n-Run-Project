using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D saw;
    private float direction;

    private bool isTouchingGround;
    public Transform groundCheck;
    public LayerMask ground;
    public float checkRadius;



    public SawScript()
    {
        this.direction = 1; // Saw is moving to the right
    }


    // Start is called before the first frame update
    void Start()
    {
        saw = GetComponent<Rigidbody2D>();
    }





    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position,checkRadius,ground);

        if (isTouchingGround) {
            saw.velocity = new Vector2(speed * direction, saw.velocity.y);
        }
        
            
        
    }
}
