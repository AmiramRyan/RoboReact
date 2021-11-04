using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]private Transform cam;
    [SerializeField] private Transform target;
    private float xOffset = 83.5f;

    void Update()
    {
        cam.transform.position = new Vector3(target.transform.position.x - xOffset, cam.transform.position.y, cam.transform.position.z);
    }
}
