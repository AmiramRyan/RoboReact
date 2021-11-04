using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public RotatingBlock[] purpleBlocks;
    public RotatingBlock[] yellowBlocks;
    public RotatingBlock[] greenBlocks;
    private bool rotatePurpleActive = false;
    private bool rotateYellowActive = false;
    private bool rotateGreenActive = false;
    private void Update()
    {
        if (Input.GetKeyDown("1") && OthersInactive("purple"))
        {
            rotatePurpleActive = !rotatePurpleActive;
            SetRotation(purpleBlocks, rotatePurpleActive);
        }
        if (Input.GetKeyDown("2") && OthersInactive("yellow"))
        {
            rotateYellowActive = !rotateYellowActive;
            SetRotation(yellowBlocks, rotateYellowActive);
        }
        if (Input.GetKeyDown("3") && OthersInactive("green"))
        {
            rotateGreenActive = !rotateGreenActive;
            SetRotation(greenBlocks, rotateGreenActive);
        }

    }

    private void SetRotation(RotatingBlock[] blocksArr, bool rotate)
    {
        for (int i = 0; i < blocksArr.Length; i++)
        {
            blocksArr[i].rotate = rotate;
        }
    }

    private bool OthersInactive(string color)
    {
        switch (color)
        {
            case "purple":
                if(rotateYellowActive || rotateGreenActive)
                {
                    return false;
                }
                else { return true; }
            case "yellow":
                if (rotatePurpleActive || rotateGreenActive)
                {
                    return false;
                }
                else { return true; }
            case "green":
                if (rotateYellowActive || rotatePurpleActive)
                {
                    return false;
                }
                else { return true; }
            default:
                return true;
        }
    }
}
