using System.Collections;
using Unity.Collections;
using UnityEngine;

public class envmons : MonoBehaviour
{
    public publicScript publicScript;
    public GameObject pofu;
    private float x_range = 18;
    private float[] y_range = {0.4f, 0.5f, 0.6f, 0.7f, 0.8f, 0.9f, 1f, 1.2f, 1.4f};

    public float spawnDelayPofu = 4f;

    private void Awake()
    {
        GameObject monster = pofu;
        StartCoroutine(SpawnPrefabWithDelay());
    }

    IEnumerator SpawnPrefabWithDelay()
    {
        GameObject monster = pofu;
        while (true){
            Vector2 spawn = new Vector2 (x_range, y_range[publicScript.randomNumberGenerator(y_range.Length)]);
            // Instantiate the prefab at the position of the spawner (this object)
            Instantiate(pofu, spawn, Quaternion.identity);

            // Wait for the specified delay before spawning the next prefab
            yield return new WaitForSeconds(spawnDelayPofu);
            }
    }
}
