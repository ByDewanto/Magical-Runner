using System.Collections;
using UnityEngine;

public class envcloud : MonoBehaviour
{
    public GameObject cloud;
    private float[] y_range = {2.8f, 3f, 3.2f, 3.4f, 3.6f, 3.8f, 4f};
    private float[] spawnDelayCloud = {0.8f, 1f, 1.2f, 1.4f, 1.6f, 1.8f};
    private void Awake() {
        StartCoroutine(SpawnPrefabWithDelay());
        // Vector2 freshSpawn = new Vector2 (-6, -4);
        // for (int i = 0; i < 10; i = i + 2){
        //     Vector2 spawn = new Vector2 (freshSpawn.x + i, freshSpawn.y);
        //     Instantiate(buildings[randomNumberGenerator(buildings.Length)], spawn, Quaternion.identity);
        // }
    }

    IEnumerator SpawnPrefabWithDelay()
    {
        while (true){
            Vector2 spawn = new Vector2 (18, y_range[randomNumberGenerator(y_range.Length)]);
            // Instantiate the prefab at the position of the spawner (this object)
            Instantiate(cloud, spawn, Quaternion.identity);

            // Wait for the specified delay before spawning the next prefab
            int rng = randomNumberGenerator(spawnDelayCloud.Length);
            yield return new WaitForSeconds(spawnDelayCloud[rng]);
        }
    }

    private int randomNumberGenerator(int length){
        return Random.Range(0, length);
    }
}
