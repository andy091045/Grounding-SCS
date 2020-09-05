using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    public GameObject player;

    Rigidbody2D rigid;
    Vector2 velocity = new Vector2();
    public float speed = 10.0f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("進來了");
        player.GetComponent<Rigidbody2D>().gravityScale = -10;
        player.GetComponent<PlayerMovement2>().speed = -10.0f;

    }
    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        velocity = new Vector2(-1f, 0) * speed;
        rigid.velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -70)
        {
            refresh();
            Destroy(GameObject.Find("gravity"));
        }

    }
    void refresh()
    {
        player.GetComponent<Rigidbody2D>().gravityScale = 10;
        player.GetComponent<PlayerMovement2>().speed = 10.0f;
    }
}
