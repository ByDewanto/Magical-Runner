using UnityEditor.Rendering;
using UnityEngine;

public class pofu : MonoBehaviour
{
    private float speedHorizontal = 1.4f;
    private float speedVertical = 4f;
    private float amplitude = 1f;
    private float frequency = 3f;
    private float timer = 0f;
    private Animator anime;

    private void Awake() {
        anime = GetComponent<Animator>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        // Calculate the y-offset based on a sine wave
        float yOffset = Mathf.Sin(timer * frequency) * amplitude;

        // Move the monster horizontally and vertically
        transform.Translate(Vector2.left * speedHorizontal * Time.deltaTime + Vector2.up * yOffset * speedVertical * Time.deltaTime);
    }
}