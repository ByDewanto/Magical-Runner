using UnityEngine;

public class playerMov : MonoBehaviour
{
    private float speed = 10f;
    private float jumpForce;
    private Rigidbody2D rb;
    public Transform groundCheck;
    private int groundCount;
    private Animator anim;

    // Start is called before the first frame update
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the player left and right
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalInput, 0);
        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
        
        Flip();
        // Jump
        if (Input.GetKeyDown(KeyCode.W) && groundCount > 0)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            groundCount--;
            jumpForce = 25f;

            anim.SetBool("ground", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("ground")){
            groundCount = 2;
            anim.SetBool("ground", true);
            jumpForce = 30f;
        }
    }

    private void Flip(){
        if (rb.velocity.x >= 0)
            transform.localScale = new Vector3(-1, 1, 1);
        else
            transform.localScale = new Vector3(1, 1, 1);
    }
}
