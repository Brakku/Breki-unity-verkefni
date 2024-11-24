using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public Transform player;
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        // n�r � navmeshi�
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // navigatar a� player ef hann er til
        if (player != null)
        {
            navMeshAgent.SetDestination(player.position);
        }
    }
}
