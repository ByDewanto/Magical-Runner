using UnityEngine;

public class beam : MonoBehaviour
{
    private Rigidbody2D beamSpell;
    private float speed = 30f;
    private void Awake() {
        beamSpell = GetComponent<Rigidbody2D>();
    }
    private void Update() {
        beamSpell.velocity = new Vector2 (speed, beamSpell.velocity.y);
        Destroy(gameObject, 6f);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
    }
}
