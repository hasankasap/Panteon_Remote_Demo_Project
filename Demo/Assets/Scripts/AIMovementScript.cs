using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovementScript : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform finish;
    public Transform startPosition;
    private void Start()
    {
        agent.SetDestination(finish.position);
       
    }

    private void SpawnStartPoint()
    {
        agent.Stop();
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);
        StartCoroutine(WaitForSpawn());
    }


    IEnumerator WaitForSpawn()
    {
        yield return new WaitForSeconds(1);
        agent.updatePosition = true;
        transform.position = startPosition.position;
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(false);
        agent.Resume();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("done");
            SpawnStartPoint();
        }
    }
}
