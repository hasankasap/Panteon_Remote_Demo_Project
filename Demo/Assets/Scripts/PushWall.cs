using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushWall : MonoBehaviour
{
    public float forwardSpeed;
    public float backwardSpeed;
    public float maxDistance = 5f;
    private float currentDistance;
    private bool isForward = true;

    private Vector3 startPoint;
    void Awake()
    {
        startPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        currentDistance = Vector3.Distance(transform.position, startPoint);

        if (isForward)
        {
            transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
            if (currentDistance >= maxDistance)
            {
                isForward = false;
            }
        }
        else
        {
            transform.Translate(Vector3.back * backwardSpeed * Time.deltaTime);
            if (currentDistance <= 0.1f)
            {
                isForward = true;
            }
        }
    }
}
