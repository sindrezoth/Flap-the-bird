using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float Speed = 2f;
    public float JumpForce = 1f;
    public float bonus = 1f;

    public float a = 1f;
    public float b = 0f;
    public float c = 0f;

    private Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime, transform.position.y, 0f);
        if(Input.GetKey(KeyCode.Space))
        {
            rigid.velocity = new Vector2(0f, JumpForce);
        }

        transform.rotation = Quaternion.FromToRotation(Vector3.right, new Vector3(Speed, rigid.velocity.y, 0f));
    }
}
