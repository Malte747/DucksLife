using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float maxJumpHeight = 5f; // Set your desired maximum jump height
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsBelowMaxHeight())
        {
            Jump();
        }
    }

     private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the bird collides with the obstacle
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Destroy the bird
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




