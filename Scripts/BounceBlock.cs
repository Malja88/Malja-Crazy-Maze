using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBlock : MonoBehaviour
{
    float power = 50;
    Vector3 bounce = new Vector3(-2,0,0);
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddRelativeForce(bounce * power, ForceMode.Impulse);
    }
}
