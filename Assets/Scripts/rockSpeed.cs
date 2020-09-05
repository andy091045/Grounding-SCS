using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigid;
    Vector2 velocity = new Vector2();
    public float speed = 10.0f;
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        velocity = new Vector2(-1f, 0) * speed;
        rigid.velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
