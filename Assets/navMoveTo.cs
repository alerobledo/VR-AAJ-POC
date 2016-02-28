using UnityEngine;
using System.Collections;

public class navMoveTo : MonoBehaviour {

    private NavMeshAgent agent;
    public Transform goal;
    private Vector3 originalPosition;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
        originalPosition = agent.transform.position;
    }

    void Update()
    {
        if (agent.remainingDistance == 0)
        {
            if (transform.position.x >= 8f)
            {
                agent.destination = originalPosition;
            }
            else
            {
                agent.destination = goal.position;
            }
        }
    }
}
