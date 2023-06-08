using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
   [SerializeField] InputHandler input;
   [SerializeField] private float ballSpeed;
    private void MoveBall()
    {
        if(input.IsTouch())
        {
            Vector2 currentPos = input.GetInputDeltaPosition();
            currentPos = currentPos * ballSpeed;
            Vector3 newGravity = new Vector3(currentPos.x, Physics.gravity.y, currentPos.y);
            Physics.gravity = newGravity;
        }
    }
    void Update()
    {
        MoveBall();
    }
}
