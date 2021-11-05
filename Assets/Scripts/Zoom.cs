using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    Vector3 touchStart;
    public float maxZoom;
    public float minZoom;
    public float sensitivity;
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            touchStart = GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(1))
        {
            Vector3 direction = touchStart - GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
            GetComponent<Camera>().transform.position += direction;
        }
        ZoomCamera(Input.GetAxis("Mouse ScrollWheel"));
    }
    void ZoomCamera(float increment)
    {
        GetComponent<Camera>().orthographicSize = Mathf.Clamp(GetComponent<Camera>().orthographicSize - increment * sensitivity, minZoom, maxZoom);
    }
}
