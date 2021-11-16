using UnityEngine;

public class MoveTransform : MonoBehaviour
{
    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime;
    }
}
