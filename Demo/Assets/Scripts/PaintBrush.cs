using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBrush : MonoBehaviour
{
    public Transform paintingObject;
    public GameObject brush;
    LayerMask mask;

    private void Awake()
    {
        mask = LayerMask.GetMask("Paint");
    }
    void Update()
    {
        SwerveInput();
    }

    public void SwerveInput()
    {

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit = new RaycastHit();

        if (Physics.Raycast(ray, out hit, mask))
        {

            if (Input.GetMouseButton(0))
            {
                brush.SetActive(true);
                transform.position = new Vector3(hit.point.x, hit.point.y, paintingObject.position.z);
            }
        }

    }
}
