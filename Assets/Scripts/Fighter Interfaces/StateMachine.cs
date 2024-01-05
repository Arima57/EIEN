using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public FighterCommon master;

    public StateMachine(FighterCommon fighter)
    {
        this.master = fighter;
    }

    public void fighterMove()
    {
        master.horizontal = Input.GetAxisRaw("Horizontal");
        if (master.horizontal != 0)
        {
            master.Walk();
        }
        else
        {
            master.Idle();
        }

        if (Input.GetButtonDown("Jump"))
        {
            master.Jump();
        }


    }



}
