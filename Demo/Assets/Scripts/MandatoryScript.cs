using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MandatoryScript : MonoBehaviour
{
    public float rotateSpeed = 5f;

    public bool isClockwise;
    public bool rotateHorizontal;
    public bool rotateVertical;

    public float movingSpeed = 5f;
    public float maxDistance = 5f;
    private float currentDistance;
    private bool isGoing = true;

    public bool isMovingLeft;
    public bool isMovingRight;
    public bool isMovingForward;
    public bool isMovingBackward;

    private Vector3 startPoint;

    private void Start()
    {
        startPoint = transform.position;
    }

    void Update()
    {
        SpinMandatory();

        currentDistance = Vector3.Distance(transform.position, startPoint);
        if (isMovingForward)
        {
            MoveForward();
        }
        else if (isMovingBackward)
        {
            MoveBacward();
        }
        else if (isMovingRight)
        {
            MoveRight();
        }
        else if (isMovingLeft)
        {
            MoveLeft();
        }
    }

    private void SpinMandatory()
    {
        if (isClockwise)
        {
            if (rotateHorizontal)
            {
                transform.Rotate(Vector3.up * 1 * rotateSpeed * Time.deltaTime);
            }
            else if (rotateVertical)
            {
                transform.Rotate(Vector3.right * 1 * rotateSpeed * Time.deltaTime);
            }
        }
        else
        {
            if (rotateHorizontal)
            {
                transform.Rotate(Vector3.up * -1 * rotateSpeed * Time.deltaTime);
            }
            else if (rotateVertical)
            {
                transform.Rotate(Vector3.right * -1 * rotateSpeed * Time.deltaTime);
            }
        }
    }

    private void MoveForward()
    {
        if (isGoing)
        {
            transform.position += Vector3.forward * movingSpeed * Time.deltaTime;
            if (currentDistance >= maxDistance)
            {
                isGoing = false;
            }
        }
        else
        {
            transform.position += Vector3.back * movingSpeed * Time.deltaTime;
            if (currentDistance <= 0.1f)
            {
                isGoing = true;
            }
        }
    }
    private void MoveBacward()
    {
        if (isGoing)
        {
            transform.position += Vector3.back * movingSpeed * Time.deltaTime;
            if (currentDistance >= maxDistance)
            {
                isGoing = false;
            }
        }
        else
        {
            transform.position += Vector3.forward * movingSpeed * Time.deltaTime;
            if (currentDistance <= 0.1f)
            {
                isGoing = true;
            }
        }
    }
    private void MoveRight()
    {
        if (isGoing)
        {
            transform.position += Vector3.right * movingSpeed * Time.deltaTime;
            if (currentDistance >= maxDistance)
            {
                isGoing = false;
            }
        }
        else
        {
            transform.position += Vector3.left * movingSpeed * Time.deltaTime;
            if (currentDistance <= 0.1f)
            {
                isGoing = true;
            }
        }
    }
    private void MoveLeft()
    {
        if (isGoing)
        {
            transform.position += Vector3.left * movingSpeed * Time.deltaTime;
            if (currentDistance >= maxDistance)
            {
                isGoing = false;
            }
        }
        else
        {
            transform.position += Vector3.right * movingSpeed * Time.deltaTime;
            if (currentDistance <= 0.1f)
            {
                isGoing = true;
            }
        }
    }
}
