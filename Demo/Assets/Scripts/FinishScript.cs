using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FinishScript : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;
    public CharacterMovement character;
    public GameObject paintingWall;
    public GameObject finishCanvas;

    IEnumerator WaitForStopMove()
    {
        yield return new WaitForSeconds(.5f);
        character.enabled = false;
        paintingWall.SetActive(true);
    }

    IEnumerator WaitForCanvasActive()
    {
        yield return new WaitForSeconds(1f);
        finishCanvas.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            vcam.m_Priority = 11;
            StartCoroutine(WaitForStopMove());
            StartCoroutine(WaitForCanvasActive());
        }
    }

}
