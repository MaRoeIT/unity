using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller_top_down : MonoBehaviour
{
    public float character_speed = 5f;

    public Rigidbody2D rigid_body;
    public Animator animator;

    Vector2 movment;

    // Update oppdaterer seg basert på frame rate
    void Update()
    {
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");

        if (animator.GetFloat("speed") == 0f )
        {
            animator.SetBool("idle", true);
        }
        else
        {
            animator.SetBool("idle", false);
        }


        animator.SetFloat("horizontal", movment.x);
        animator.SetFloat("vertical", movment.y);
        animator.SetFloat("speed", movment.sqrMagnitude);
        
    }

    // Fixed update oppdaterer 50 ganger i sekundet og derfor er mer stabilt vis man skal gjøre ting som krever pyshics slik at det ikke varierer basert på frame rate
    void FixedUpdate()
    {
        rigid_body.MovePosition(rigid_body.position + movment * character_speed * Time.fixedDeltaTime);
    }
}
