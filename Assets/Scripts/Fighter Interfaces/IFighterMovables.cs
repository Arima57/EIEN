using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFighterMovables
{
    public float speed {get;set;}
    public float jumpForce {get;set;}  //Encapsulation
    public float gravity {get;set;} //Lots and lots of encapsulation
    public float runSpeed {get;set;}
    public float dodgeSpeed {get;set;}
    public Rigidbody2D RB {get;set;}
    public Animator animator{get;set;}
    public float horizontal {get;set;}
    public float vertical {get;set;}

    public void Walk();
    public void Jump();
    public void Dodge();
    public void Run();
    public void Crouch();
    public void Idle();


}

