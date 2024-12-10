using UnityEngine;

public class pofuHealth: MonoBehaviour
{
    public float maxHealth = 20f;
    public float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("spell"))
        {
            currentHealth -= 20f;
            Debug.Log("Player hit me");
        }
        if (currentHealth <= 0){
            Destroy(gameObject);
        }
    }
}