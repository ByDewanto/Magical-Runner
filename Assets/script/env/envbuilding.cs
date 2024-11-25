using System.Collections;
using UnityEngine;

public class envbuilding : MonoBehaviour
{
    public GameObject b01;
    public GameObject b02;
    public GameObject b03;
    public GameObject b04;
    public GameObject b05;

    private float[] y_range = {-4f, -4.5f, -5f, -5.5f, -6f};
    public float spawnDelayBuilding = 2f;     // Delay between spawns
    private void Awake() {
        GameObject[] buildings = {b01, b02, b03, b04, b05};
        StartCoroutine(SpawnPrefabWithDelay());
        // Vector2 freshSpawn = new Vector2 (-6, -4);
        // for (int i = 0; i < 10; i = i + 2){
        //     Vector2 spawn = new Vector2 (freshSpawn.x + i, freshSpawn.y);
        //     Instantiate(buildings[randomNumberGenerator(buildings.Length)], spawn, Quaternion.identity);
        // }
    }

    IEnumerator SpawnPrefabWithDelay()
    {
        GameObject[] buildings = {b01, b02, b03, b04, b05};
        while (true){
            Vector2 spawn = new Vector2 (18, y_range[randomNumberGenerator(y_range.Length)]);
            // Instantiate the prefab at the position of the spawner (this object)
            Instantiate(buildings[randomNumberGenerator(buildings.Length)], spawn, Quaternion.identity);

            // Wait for the specified delay before spawning the next prefab
            yield return new WaitForSeconds(spawnDelayBuilding);
        }
    }

    private int randomNumberGenerator(int length){
        return Random.Range(0, length);
    }
}
