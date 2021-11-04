using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBlock : MonoBehaviour
{
    [SerializeField]private Transform axelTrans;
    private bool rotated = false;
    
    public void RotateBlock()
    {
        //turn 90 degrees
        if (rotated)
        {
            axelTrans.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else
        {
            axelTrans.rotation = Quaternion.Euler(0f,90f, 0f); 
        }
        rotated = !rotated;
    }
}
