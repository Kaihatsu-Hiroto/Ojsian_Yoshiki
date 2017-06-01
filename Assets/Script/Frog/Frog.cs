using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour {

    Rigidbody2D rigidbody;//上昇

    Animator animator;

    public void Initialize()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    public void UpdateByFrame()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play("Frog_jump");
            rigidbody.velocity = new Vector3(5, 5, 0);
        }
        else
        {
            animator.Play("Frog_Idle");
        }

    }

}
