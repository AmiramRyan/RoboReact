using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBlock : MonoBehaviour
{
    //generic rotation script
    [SerializeField]private Transform axelTrans;
    public float rotationSpeed;
    public bool rotate = false;

    public void Update()
    {
        if (rotate)
        {
            axelTrans.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}
