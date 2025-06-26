using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIChaser : MonoBehaviour
{
    [Tooltip("Drag your Player here, or make sure your player is tagged 'Player'")]
    public Transform target;

    private NavMeshAgent agent;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();

        // Auto-find the player by tag if you forgot to assign it
        if (target == null)
        {
            var playerGO = GameObject.FindGameObjectWithTag("Player");
            if (playerGO != null)
                target = playerGO.transform;
            else
                Debug.LogWarning($"[{name}] No target assigned and no GameObject tagged 'Player' found.");
        }
    }

    void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
    }
}
