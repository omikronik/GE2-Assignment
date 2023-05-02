using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerController : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "berry_bush")
        {
            GetComponent<StateMachine>().ChangeState(new GoToBerryState());
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<StateMachine>().ChangeState(new ScavengeState());
        GetComponent<StateMachine>().SetGlobalState(new Alive());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
