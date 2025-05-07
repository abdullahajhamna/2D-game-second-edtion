using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 8f;  // Adjustable speed in Inspector
    [SerializeField] private float jumpForce = 10f; // How high the player jumps

    [Header("Ground Check")]
    [SerializeField] private Transform groundCheck; // Drag a child GameObject here (positioned at feet)
    [SerializeField] private LayerMask groundLayer; // Assign the "Ground" layer in Inspector

    private Rigidbody2D rb;
    private bool isGrounded;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component
    }

    void Update()
    {
        // --- Check if player is grounded ---
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        // --- Jumping ---
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); // Apply jump force
        }
    }

    void FixedUpdate()
    {
        // --- Left/Right Movement ---
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }

   
}