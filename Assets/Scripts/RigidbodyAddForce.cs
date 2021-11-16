using UnityEngine;

public class RigidbodyAddForce : MonoBehaviour
{
    public float forceMultiplier = 200;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //Works better with object using Gravity / Physics System
        //Does Not Work on Kinematic Object
        rb.AddForce(transform.forward * forceMultiplier * Time.deltaTime);
    }
}
