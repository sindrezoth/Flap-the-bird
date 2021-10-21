using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsDestroyer : MonoBehaviour
{
    public GameObject Bird;
    private const float _offset = -5f;

    void FixedUpdate()
    {
        transform.position = new Vector3(Bird.transform.position.x + _offset, 0f, 0f);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        Object.Destroy(collision.gameObject);
    }
}
