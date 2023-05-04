using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// State for looking for berries
class ScavengeState : State
{
    public override void Enter()
    {
        owner.GetComponent<JitterWander>().enabled = true;
        owner.GetComponent<Arrive>().enabled = false;
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
    public GameObject berry;

    public GoToBerryState(GameObject berry)
    {
        this.berry = berry;
    }

    public override void Enter()
    {
        owner.GetComponent<JitterWander>().enabled = false;
        owner.GetComponent<Arrive>().enabled = true;
        owner.GetComponent<Arrive>().targetGameObject = berry;
        owner.GetComponent<VillagerController>().StartCoroutine(owner.GetComponent<VillagerController>().CollectionTimer());
    }

    public override void Exit()
    { 
        owner.GetComponent<Arrive>().targetGameObject = null;
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

