using UnityEngine;

public class cloudmov : MonoBehaviour
{
    private Rigidbody2D cloud;
    private float speed = 2f;
    private void Awake() {
        cloud = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        cloud.velocity = new Vector2(-speed, cloud.velocity.y);
        Destroy(gameObject, 20f);
    }
}
