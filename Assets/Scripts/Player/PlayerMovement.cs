using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 4;

    private NavMeshAgent agent;

    private Vector3 targetPosition;
    private bool isMoveing = false;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

    }
    private void Update()
    {
        agent.speed = speed;

        if (Input.GetMouseButtonDown(0))
        {
            SetTargetPosition();
        }
    }

    void SetTargetPosition()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        agent.SetDestination(targetPosition);

        isMoveing = true;
    }
}

