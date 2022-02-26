using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    [SerializeField] private Animator animator;

    [SerializeField] private float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;

    private void Update() 
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("Jump", true);
        }
    }

    public void OnLanding()
    {
        animator.SetBool("Jump", false);
    }

    private void FixedUpdate()
    {
        //Move our character here.
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
