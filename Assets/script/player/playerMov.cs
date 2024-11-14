using UnityEngine;

public class playerMov : MonoBehaviour
{
    private float speed = 10f;
    private float jumpForce = 40f;
    private Rigidbody2D rb;
    public Transform groundCheck;
    
    private int groundCount;

    // Start is called before the first frame update
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the player left and right
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalInput, 0);
        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
        
        // Jump
        if (Input.GetButtonDown("Jump") && groundCount > 0)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            groundCount--;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("ground")){
            groundCount = 2;
        }
    }
}
