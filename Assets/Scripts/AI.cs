using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

            
    }
    public void Follow()
    {
        agent.SetDestination(player.gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
    }
}
