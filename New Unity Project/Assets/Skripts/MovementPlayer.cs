using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float speed;
    public float HeightJump;
    public float distanceToTheGround;

    private Rigidbody rb;
    private float moveInput;
    private bool facingRight = true;
    private bool groundTouch;
    private Transform checkingGround;
    private LayerMask definitionOfLand;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        MovePositionX();
    }

    void MovePositionX()
    {
        //groundTouch = Physics2D.OverlapCircle(checkingGround.position, distanceToTheGround);
        
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity =new Vector3(moveInput *speed, rb.position.z);
        if (facingRight == false && moveInput > 0)
            TurnAround();
        else if (facingRight == true && moveInput < 0)
            TurnAround();

    }

    void TurnAround()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }


   
    
}
