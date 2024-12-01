using UnityEngine;

/**
 * This script spawns HealthPickup objects at regular intervals in random positions.
 */
public class HealthPickupSpawner : MonoBehaviour
{
    [Tooltip("Prefab of the health pickup to spawn")]
    [SerializeField] GameObject healthPickupPrefab;

    [Tooltip("Time interval between spawning health pickups (in seconds)")]
    [SerializeField] float spawnInterval = 20f;

    [Tooltip("Bounds for spawning (X for horizontal range, Y for vertical range)")]
    [SerializeField] Vector2 spawnArea = new Vector2(10f, 5f);

    [Tooltip("Maximum number of health pickups allowed on screen at once")]
    [SerializeField] int maxPickups = 2;

    private void Start()
    {
        // Start spawning health pickups repeatedly
        InvokeRepeating("SpawnHealthPickup", spawnInterval, spawnInterval);
    }

    private void SpawnHealthPickup()
    {
        // Check if the number of pickups on screen is below the maximum
        if (healthPickupPrefab != null && GameObject.FindGameObjectsWithTag("HealthPickup").Length < maxPickups)
        {
            // Generate a random position within the spawn area
            float x = Random.Range(-spawnArea.x, spawnArea.x);
            float y = Random.Range(-spawnArea.y, spawnArea.y);
            Vector2 spawnPosition = new Vector2(x, y);

            // Instantiate a health pickup at the random position
            Instantiate(healthPickupPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
