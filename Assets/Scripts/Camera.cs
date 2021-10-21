using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Bird;
    private float _defaultZPos = -10f;
    void Update()
    {
        transform.position = new Vector3(Bird.transform.position.x, 0f, _defaultZPos);
    }
}
