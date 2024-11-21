using UnityEngine;

public class buildingmov : MonoBehaviour
{
    private Rigidbody2D building;
    private float speed = 4f;
    private void Awake() {
        building = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        building.velocity = new Vector2(-speed, building.velocity.y);
        Destroy(gameObject, 10f);
    }
}
