using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorGruond : MonoBehaviour
{
    public float rotateSpeed = 5f;

    public bool isClockwise;

    void Update()
    {
        SpinGround();
    }

    private void SpinGround()
    {
        if (isClockwise)
        {
            transform.Rotate(Vector3.right * 1 * rotateSpeed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(Vector3.right * -1 * rotateSpeed * Time.deltaTime);
        }
    }
}
