using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float minPosX;
    public float maxPosX;

    public float moveDistance = 1f;
    public float timeStep = 1f;

    bool isMovingRight = true;

    void Start()
    {
        InvokeRepeating("Move", timeStep, timeStep);
    }

    void Update()
    {
        
    }

    void Move()
    {
        if (isMovingRight)
        {
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos + new Vector3(moveDistance, 0f);
            transform.position = newPos;

            if (transform.position.x >= maxPosX)
            {
                isMovingRight = false;
            }
        }
        else
        {
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos - new Vector3(moveDistance, 0f);
            transform.position = newPos;

            if (transform.position.x <= minPosX)
            {
                isMovingRight = true;
            }
        }
    }
}