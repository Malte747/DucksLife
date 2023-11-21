using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float maxJumpHeight = 5f; // Set your desired maximum jump height
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsBelowMaxHeight())
        {
            Jump();
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        } 
    }


    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    bool IsBelowMaxHeight()
    {
        // Check if the bird's current Y position is below the maximum jump height
        return transform.position.y < maxJumpHeight;
    }
}




