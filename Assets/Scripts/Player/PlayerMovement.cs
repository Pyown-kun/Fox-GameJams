using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public bool IsMoveing = false;
    [SerializeField] private float speed = 4;

    private Animator animator;
    private NavMeshAgent agent;
    private SpriteRenderer spriteRenderer;
    private Vector3 targetPosition;
    private Vector3 direction;

    private void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

    }
    private void Update()
    {
        agent.speed = speed;

        if (Input.GetMouseButtonDown(0) && IsMoveing)
        {
            SetTargetPosition();
        }

        if (direction.x < 0)
        {
            spriteRenderer.flipX = true;
        }

        if (direction.x >= 0)
        {
            spriteRenderer.flipX = false;
        }

        if (agent.velocity.magnitude == 0)
        {
            animator.SetBool("isRunning", false);
        }
        else if (agent.velocity.magnitude > 0)
        {
            animator.SetBool("isRunning", true);
        }
    }

    void SetTargetPosition()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        agent.SetDestination(targetPosition);

        direction = (targetPosition - transform.position).normalized;

       


        IsMoveing = false;
    }
}

