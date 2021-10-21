using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float Speed = 2f;
    public float JumpForce = 1f;
    public float JumpAngle = 30f;
    public float bonus = 1f;

    public float a = 1f;
    public float b = 0f;
    public float c = 0f;
    public float t = 1.2f;
    private float tz = 0f;

    private Rigidbody2D rigid;

    void Awake()
    {
    }

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime, transform.position.y, 0f);
        if(Input.GetKey(KeyCode.Space))
        {
            Fly();
        }
        else if(tz >= t)
        {
            Fly();
            tz = 0f;
        }
        float parabolaX = rigid.velocity.y;
        //a * (parabolaX * parabolaX) + b * parabolaX + c, parabolaX, 0
        //transform.rotation = Quaternion.FromToRotation(new Vector3( Speed, rigid.velocity.y, 0), Vector3.up);
        //transform.LookAt(new Vector3( Speed, rigid.velocity.y, 0), Vector3.down);
        tz += Time.deltaTime;

        Debug.DrawRay(transform.position, new Vector3(Speed, rigid.velocity.y, 0f));
        Debug.DrawRay(transform.position, Vector3.right);
        transform.rotation = Quaternion.FromToRotation(Vector3.right, new Vector3(Speed, rigid.velocity.y, 0f));
    }

    void Fly()
    {
        Debug.Log(rigid.velocity.y);
        rigid.velocity = new Vector2(0f, JumpForce);
    }
}
