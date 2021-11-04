using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public RotatingBlock thisRotate;
    private void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            thisRotate.RotateBlock();
        }
    }
}
