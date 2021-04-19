using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 15f;

    public Animator anim;
    public bool canMove = true;

    private Vector3 fingerFirstPosition;
    private Vector3 fingerDirection;
    private Vector3 lookVector;

    void Update()
    {
        SwerveInput();
        transform.LookAt(lookVector);
        if (canMove)
        {
            if (fingerDirection.magnitude >= 0.1f)
            {
                //float targetAngel = Mathf.Atan2(fingerDirection.x, fingerDirection.y) * Mathf.Rad2Deg; // calculate player facing direction
                //transform.rotation = Quaternion.Euler(0, targetAngel, 0);
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                anim.SetBool("isMoving", true);
            }
            else
            {
                anim.SetBool("isMoving", false);
            }
        }
    }

    public void SwerveInput()                   
    {
        if (Input.GetMouseButtonDown(0))
        {
            fingerFirstPosition = Input.mousePosition; // get first touch
        }
        else if (Input.GetMouseButton(0))
        {
            fingerDirection = Input.mousePosition - fingerFirstPosition; // get finger moving direction
            lookVector = new Vector3(fingerDirection.x, 0, fingerDirection.y);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            lookVector = new Vector3(fingerDirection.x, 0, fingerDirection.y);
            fingerDirection = Vector3.zero;         // stoping movement when finger up
        }
    }
}
