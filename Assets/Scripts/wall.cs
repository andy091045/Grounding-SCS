using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    float time_f = 0.0f;
    int time_i = 0;

    public int gapTime = 10;
    int originTime = 0;
    public float increaseSpeed = 0.1f;
    public GameObject wallProuducts;
    Vector2 velocity = new Vector2();
    public float speed = 10.0f;
    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        // velocity = new Vector2(-1, 0) * speed;
        // rigid.velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        // time_f += Time.deltaTime;
        // time_i = (int)time_f;

        // if ((time_i - originTime) >= gapTime)
        // {
        //     speed += 2.0f;
        //     Debug.Log(speed);
        //     originTime = time_i;
        // }
        // speed += increaseSpeed;
        // Debug.Log(speed);
        run();

    }
    void run()
    {
        velocity = new Vector2(-1, 0) * speed;
        rigid.velocity = velocity;
    }
}
