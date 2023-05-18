using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public float targetSpeed = 10f;
    public float targetAcceleration = 8f;
    public float duration = 5f;

    private NavMeshAgent navMeshAgent;
    private float initialSpeed;
    private float initialAcceleration;
    private float elapsedTime;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        initialSpeed = navMeshAgent.speed;
        initialAcceleration = navMeshAgent.acceleration;
        elapsedTime = 0f;
    }

    private void Update()
    {
        if (elapsedTime < duration)
        {
            // Calculate the speed and acceleration increase over time
            float t = elapsedTime / duration;
            float currentSpeed = Mathf.Lerp(initialSpeed, targetSpeed, t);
            float currentAcceleration = Mathf.Lerp(initialAcceleration, targetAcceleration, t);

            // Update the NavMeshAgent's speed and acceleration
            navMeshAgent.speed = currentSpeed;
            navMeshAgent.acceleration = currentAcceleration;

            // Increase the elapsed time
            elapsedTime += Time.deltaTime;
        }
        else
        {
            // Reached the target speed and acceleration, do something else or stop the increase
        }
    }
}