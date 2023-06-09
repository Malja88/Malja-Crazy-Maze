using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Vector2 GetInputDeltaPosition()
    {
        if(Input.touchCount > 0)
        {
           return Input.GetTouch(0).deltaPosition;
        }
        return Vector2.zero;
    }
    public bool IsTouch()
    {
        if(Input.touchCount > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
