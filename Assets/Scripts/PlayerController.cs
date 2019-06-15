using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed;
    private float movement;
    private float jumpSpeed;
    private Rigidbody2D player;
    

    private bool isTouchingGround;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask ground;

    private Animator moving;
    private bool isFighting;
    private float playerScaleX;
    private float playerScaleY;

    public PlayerController()
    {
        this.speed = 3f;
        this.movement = 0f;
        this.jumpSpeed = 5f;
        this.playerScaleX = 0.24045f;
        this.playerScaleY = this.playerScaleX;


    }



    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();

        moving = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, checkRadius, ground);

        movement = Input.GetAxis("Horizontal");
        if (movement > 0f)
        {
            player.velocity = new Vector2(movement * speed, player.velocity.y);
            transform.localScale = new Vector2(playerScaleX, 0.24045f);

        }
        else if (movement < 0f)
        {
            player.velocity = new Vector2(movement * speed, player.velocity.y);
            transform.localScale = new Vector2(((-1) * playerScaleX), 0.24045f);

        }
        else
        {
            player.velocity = new Vector2(0f, player.velocity.y);
        }

        if (Input.GetKey("space")  && isTouchingGround )
        {
            player.velocity = new Vector2(movement * speed, jumpSpeed);

        }

        if (Input.GetKey("f") && isTouchingGround )
        {
            isFighting = true;
        }
        else
        {
            isFighting = false;
        }
        

        moving.SetFloat("Speed", Mathf.Abs(player.velocity.x));
        moving.SetBool("OnGround", isTouchingGround);
        moving.SetBool("IsFighting", isFighting); 

    }
}



