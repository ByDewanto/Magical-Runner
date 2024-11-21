using UnityEngine;

public class enchant : MonoBehaviour
{
    public GameObject prefabToSpawn;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Calculate the spawn position based on the Rigidbody2D's position and the offset
            Vector2 spawnPosition = new Vector2 (rb.position.x + 2f, rb.position.y);

            // Instantiate the prefab at the calculated position
            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}
