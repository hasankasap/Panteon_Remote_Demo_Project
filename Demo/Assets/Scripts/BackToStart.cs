using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BackToStart : MonoBehaviour
{
    public Transform startPosition;
    private GameObject collidedObject;
    private CharacterMovement character;

    private void SpawnStartPoint()
    {
        
        collidedObject.transform.GetChild(0).gameObject.SetActive(false);
        collidedObject.transform.GetChild(1).gameObject.SetActive(true);
        StartCoroutine(WaitForSpawn());
    }


    IEnumerator WaitForSpawn()
    {
        yield return new WaitForSeconds(1);
        collidedObject.GetComponent<Transform>().position = startPosition.position;
        collidedObject.transform.GetChild(0).gameObject.SetActive(true);
        collidedObject.transform.GetChild(1).gameObject.SetActive(false);
        character.canMove = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            collidedObject = other.gameObject;
            character = collidedObject.GetComponent<CharacterMovement>();
            character.canMove = false;
            SpawnStartPoint();
        }
    }
}
