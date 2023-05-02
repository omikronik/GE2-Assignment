using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// State for looking for berries
class ScavengeState : State
{
    public override void Enter()
    {
        owner.GetComponent<JitterWander>().enabled = true;
    }

    public override void Exit()
    { 
        base.Exit();
    }

    public override void Think()
    {
        base.Think();
    }
}
class GoToBerryState : State
{
    public override void Enter()
    {
        owner.GetComponent<JitterWander>().enabled = false;
    }

    public override void Exit()
    { 
        owner.GetComponent<JitterWander>().enabled = false;
    }

    public override void Think()
    {
        base.Think();
    }
}

class GoToBaseState : State
{
    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    { 
        base.Exit();
    }

    public override void Think()
    {
        base.Think();
    }
}

class AttackState : State
{
    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    { 
        base.Exit();
    }

    public override void Think()
    {
        base.Think();
    }
}

class NearestPursue : State
{
    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Think()
    {
        base.Think();
    }
}

class Alive : State
{
    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    { 
        base.Exit();
    }

    public override void Think()
    {
        base.Think();
    }
}

