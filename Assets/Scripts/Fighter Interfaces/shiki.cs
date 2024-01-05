using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class shiki : FighterCommon //Inheritence
{

    private int jumped = 0;
    private StateMachine stateMachine;
    private int maxJump = 2;


    private void Awake()
    {
        stateMachine = new StateMachine(this);
    }

    private void Update()
    {
        stateMachine.fighterMove(); //Abstraction
    }

    public override void Jump() //Polymorphism
    //very high levels of polymorphism.
    {
        if (jumped < maxJump)
        {
            base.Jump(); 
        }
        jumped++;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        jumped = 0;
    }
}
