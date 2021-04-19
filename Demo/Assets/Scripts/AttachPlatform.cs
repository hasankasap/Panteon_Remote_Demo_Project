using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlatform : MonoBehaviour
{
    private RigidbodyConstraints rb;
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.parent = transform;
        rb = other.gameObject.GetComponent<Rigidbody>().constraints;
        other.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
    }
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.transform.parent = null;
        other.gameObject.GetComponent<Rigidbody>().constraints = rb;
    }
}
