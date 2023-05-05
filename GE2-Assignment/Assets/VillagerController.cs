using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerController : MonoBehaviour
{
    public GameObject VillagePointRef;
    public GameObject ArrowPrefab;
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
        if (other.tag == "berry_bush" && hasBerry == false)
        {
            GetComponent<StateMachine>().ChangeState(new GoToBerryState(other.gameObject));
        }

        if (other.tag == VillagePointRef.tag && hasBerry == true)
        {

            GetComponent<StateMachine>().ChangeState(new ScavengeState());
        }
    }

    public IEnumerator CollectionTimer()
    {
        yield return new WaitForSeconds(collectionTimer);
        hasBerry = true;
        GetComponent<StateMachine>().ChangeState(new GoToBaseState(VillagePointRef));
    }

    public IEnumerator DepositTimer()
    {
        yield return new WaitForSeconds(collectionTimer);
        hasBerry = false;
        GetComponent<StateMachine>().ChangeState(new ScavengeState());
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
        //transform.LookAt(Vector3.forward);
    }
}
