using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonutRotate : MonoBehaviour
{
    public float rotateSpeed = 5f;

    public bool isClockwise;
    public bool rotateHorizontal;
    public bool rotateVertical;

    void Update()
    {
        SpinDonut();
    }

    private void SpinDonut()
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
}
