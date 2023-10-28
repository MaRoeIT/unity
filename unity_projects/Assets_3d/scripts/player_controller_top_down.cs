using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller_top_down : MonoBehaviour
{
    public float character_speed = 5f;

    public Rigidbody rigid_body;

    Vector3 movment;

    // Update oppdaterer seg basert på frame rate
    void Update()
    {
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.z = Input.GetAxisRaw("Vertical");
    }

    // Fixed update oppdaterer 50 ganger i sekundet og derfor er mer stabilt vis man skal gjøre ting som krever pyshics slik at det ikke varierer basert på frame rate
    void FixedUpdate()
    {
        rigid_body.MovePosition(rigid_body.position + movment * character_speed * Time.fixedDeltaTime);
    }
}
