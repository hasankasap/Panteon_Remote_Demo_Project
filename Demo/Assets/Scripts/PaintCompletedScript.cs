using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class PaintCompletedScript : MonoBehaviour
{
    public GameObject paintWallPercentage;
    public GameObject levelComplatePanel;
    public CinemachineVirtualCamera vcam;

    void Update()
    {
        float a = paintWallPercentage.GetComponent<Image>().fillAmount;
        if (a == 1)
        {
            Debug.Log("done");
            vcam.m_Priority = 12;
            levelComplatePanel.SetActive(true); // add finish UI here
        }
    }
}
