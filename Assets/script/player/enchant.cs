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
            Vector2 spawnPosition = new Vector2 (rb.position.x + 1.5f, rb.position.y);

            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}
