using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickRotatorScript : MonoBehaviour
{
    public float rotateSpeed = 5f;

    public bool isClockwise;

    void Update()
    {
        RotateStcik();
    }

    private void RotateStcik()
    {
        if (isClockwise)
        {
            transform.Rotate(Vector3.up * 1 * rotateSpeed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(Vector3.up * -1 * rotateSpeed * Time.deltaTime);
        }
    }
}
