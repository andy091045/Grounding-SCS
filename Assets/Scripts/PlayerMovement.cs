using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{

    public PlayerType playerType;
    public event Action<int> shoot;
    Vector2 velocity = new Vector2();
    public float speed = 10.0f;
    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //移動
        if (playerType == PlayerType.A)
        {
            velocity = new Vector2(Input.GetAxisRaw("AHorizontal"), Input.GetAxisRaw("AVertical")) * speed;

            //發射
            if (Input.GetKeyUp(KeyCode.Space))
            {
                if (shoot != null) { shoot(1); }
            }
        }
        rigid.velocity = velocity;
    }
    public enum PlayerType
    {
        A, B
    }
}
