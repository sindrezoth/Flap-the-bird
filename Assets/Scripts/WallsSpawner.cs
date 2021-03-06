using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsSpawner : MonoBehaviour
{
    private const float X_OFFSET = 5f;

    public GameObject TubePrefab;
    public GameObject Bird;

    public float DistanceFromCenter = 4;
    public float SpawnRange = 3;
    public float Frequency = 1;

    private float _spawnCooldown;
    private float _timer = 0;

    void Update()
    {
      transform.position = new Vector3(Bird.transform.position.x + X_OFFSET, 0f, 0f);

      if(_timer >= _spawnCooldown)
      {
          Spawn();
          _timer = 0;
          _spawnCooldown = Random.Range(3, 5) / Frequency;
      }
      _timer += Time.deltaTime;
    }

    void Spawn()
    {
        float range = Random.Range(-SpawnRange, SpawnRange);

        Object.Instantiate(TubePrefab, new Vector2(transform.position.x, range - DistanceFromCenter), Quaternion.identity);
        Object.Instantiate(TubePrefab, new Vector2(transform.position.x, range + DistanceFromCenter), Quaternion.LookRotation(transform.forward, Vector2.down));
    }
}
