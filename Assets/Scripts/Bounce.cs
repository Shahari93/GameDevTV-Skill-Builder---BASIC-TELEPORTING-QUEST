// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv

using UnityEngine;

public class Bounce : MonoBehaviour
{
    [SerializeField] float jumpForce = 1000f;
    private Vector3 upVector = Vector3.up;

    void OnTriggerEnter(Collider other)
    {
        // Challenge 1: JumpyJumpy(other);
        JumpForce(other);
    }

    void JumpForce(Collider other)
    {
        GameObject player = other.gameObject;
        if (player.CompareTag("Player"))
        {
            Rigidbody rb = player.GetComponent<Rigidbody>();
            rb.AddForce(upVector * jumpForce, ForceMode.Force);
        }
    }
}