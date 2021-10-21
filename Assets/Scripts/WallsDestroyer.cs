using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsDestroyer : MonoBehaviour
{
    public GameObject Bird;
    private const float X_OFFSET = -5f;

    void FixedUpdate()
    {
        transform.position = new Vector3(Bird.transform.position.x + X_OFFSET, 0f, 0f);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Object.Destroy(collision.gameObject);
    }
}
