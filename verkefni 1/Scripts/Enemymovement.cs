using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public Transform player;
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        // nær í navmeshið
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // navigatar að player ef hann er til
        if (player != null)
        {
            navMeshAgent.SetDestination(player.position);
        }
    }
}
