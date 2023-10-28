using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tnt_goes_boom : MonoBehaviour
{
    public Animator tnt_animator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            tnt_animator.SetBool("triggered", true);
            
        }
        
    }

    public void end_life()
    {
        Destroy(gameObject);
    }
}
