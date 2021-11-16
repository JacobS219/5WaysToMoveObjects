using UnityEngine;

public class RigidbodySetVelocity : MonoBehaviour
{
    public float forceMultiplier = 200;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        //Good for setting velocity at Awake
        //rb.velocity = transform.forward * Time.deltaTime * forceMultiplier;
    }

    private void Update()
    {
        //Works better with object using Gravity / Physics System
        //Does Not work on Kinematic object
        rb.velocity = transform.forward * Time.deltaTime * forceMultiplier;
    }
}
