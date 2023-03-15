using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    [SerializeField] Transform location;
    private NavMeshAgent navMeshAgent;
    [SerializeField] float distanceToPlayer;
    [SerializeField] float mandatedDistanceToPlayer = 30f;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position , location.position);

        if (distanceToPlayer <= mandatedDistanceToPlayer)
        {
            navMeshAgent.destination = location.position;
        }
    }
}
