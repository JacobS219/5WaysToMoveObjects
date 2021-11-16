using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMovePosition : MonoBehaviour
{
    public float forceMultiplier = 2;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //Vector3 newPosition = transform.position + (transform.forward * Time.deltaTime) * forceMultiplier;  Super Fast
        Vector3 newPosition = transform.position + (transform.forward * Time.deltaTime);
        rb.MovePosition(newPosition);
    }
}
