using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public PlayerType playerType;

    public GameObject blocker;
    Vector2 velocity = new Vector2();
    public float speed = 10.0f;
    public Rigidbody2D rigid;

    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnTri(Collision2D other)
    {
        Debug.Log("玩家死了");

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("玩家死了");
    }

    // Update is called once per frame
    void Update()
    {
        //移動
        if (playerType == PlayerType.A)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                velocity = new Vector2(0, 1) * speed;
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                velocity = new Vector2(0, 0) * speed;
            }
        }
        rigid.velocity = velocity;
    }
    public enum PlayerType
    {
        A, B
    }
}
