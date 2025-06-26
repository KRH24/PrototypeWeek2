using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIChaser : MonoBehaviour
{
    [Tooltip("Drag your Player here, or make sure your player is tagged 'Player'")]
    public Transform target;

    public GameObject player;

    public float speed = 5f;



    void Update()
    {
        if (target != null)
        {
            Vector2 direction = (target.position - transform.position).normalized;
            transform.position += (Vector3)(direction * speed * Time.deltaTime);
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Destroy(other.gameObject);

        }

    }
}
