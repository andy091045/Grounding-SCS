using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


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
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject player = GameObject.Find("Player2");
            player.GetComponent<PlayerMovement2>().Dead();
        }
    }
}
