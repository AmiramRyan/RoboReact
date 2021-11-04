using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public RotatingBlock[] purpleBlocks;
    private void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            for(int i = 0; i < purpleBlocks.Length; i++)
            {
                purpleBlocks[i].rotate = !purpleBlocks[i].rotate;
            }
        }
    }
}
