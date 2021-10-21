using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Bird;
    private const float DEFAULT_Z_POSITION = -10f;
    void Update()
    {
        transform.position = new Vector3(Bird.transform.position.x, 0f, DEFAULT_Z_POSITION);
    }
}
