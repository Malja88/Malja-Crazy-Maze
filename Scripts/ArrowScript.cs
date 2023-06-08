using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] Rigidbody rb;
    Vector3 arrowPoint = new Vector3(0, 0, -1);
    void Start()
    {
        rb.velocity = arrowPoint * speed;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);   
        }
    }
}
