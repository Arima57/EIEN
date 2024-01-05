using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterCommon : MonoBehaviour, IFighterMovables, IFigtherCombat  //Inheritence
{


    /*

    FIELDS 

    */

    public float speed {get;set;} = 5f;
    public float jumpForce {get;set;} = 10f;
    public float gravity {get;set;}
    public float runSpeed { get;set;} = 20f;
    public float dodgeSpeed { get ;  set ;  }
    public Rigidbody2D RB {get;set;}
    public Animator animator{get;set;}
    public Vector3 velocity;
    public float horizontal {get;set;}
    public float vertical {get;set;}




    /*
    
    METHODS
    */
    public void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    public void Crouch()
    {
    }

    public void Dodge()
    {
        
    }

    public void Idle()
    {
        animator.ResetTrigger("Jump");
        animator.SetFloat("Speed", 0f);
    }

    public virtual void Jump()
    {
        animator.SetTrigger("Jump");
        RB.AddForce(Vector2.up * 1500, ForceMode2D.Impulse);
    }

    public void Run()
    {
        RB.velocityX =  runSpeed * Time.deltaTime;
        animator.SetFloat("Speed", runSpeed);
    }

    public void Walk()
    {
        velocity.x = speed * Time.deltaTime * horizontal;
        transform.position += velocity;
        animator.SetFloat("Speed", speed * horizontal);
    }
}
