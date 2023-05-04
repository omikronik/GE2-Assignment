using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerController : MonoBehaviour
{
    float collectionTimer = 3.0f;
    public bool hasBerry = false;

    void OnDrawGizmos()
    {
        BoxCollider collider = GetComponent<BoxCollider>();
        if (collider != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.matrix = transform.localToWorldMatrix;
            Gizmos.DrawWireCube(collider.center, collider.size);
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("collided berry");
        if (other.tag == "berry_bush")
        {
            Debug.Log("collided berry");
            GetComponent<StateMachine>().ChangeState(new GoToBerryState());
        }
    }

    IEnumerator CollectionTimer()
    {
        yield return new WaitForSeconds(collectionTimer);
        GetComponent<StateMachine>().ChangeState(new GoToBaseState());
    }

    public void OnTriggerStay(Collider other)
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<StateMachine>().ChangeState(new ScavengeState());
        GetComponent<StateMachine>().SetGlobalState(new Alive());

        Debug.Log("hello");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
