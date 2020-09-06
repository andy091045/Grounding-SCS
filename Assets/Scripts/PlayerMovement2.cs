using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audiosource;
    public GameObject canvas;
    //旋轉
    float smooth = 5.0f;
    float tiltAngle = 60.0f;

    public Sprite p2;
    public PlayerType playerType;

    public GameObject blocker;
    Vector2 velocity = new Vector2();
    public float speed = 10.0f;
    public Rigidbody2D rigid;

    public float gapTime = 2;
    public float timer = 0;
    int gLock = 0;

    void Start()
    {
        //    canvas = GameObject.Find("Canvas");
        rigid = gameObject.GetComponent<Rigidbody2D>();
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        audiosource = GetComponent<AudioSource>();
    }

    // private void OnTri(Collision2D other)
    // {
    //     Debug.Log("玩家死了");

    // }
    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     Debug.Log("玩家死了");
    // }

    // Update is called once per frame
    void Update()
    {
        if (timer >= gapTime && gLock == 0)
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 10;
            gLock = 1;
        }
        //移動
        if (playerType == PlayerType.A)
        {
            velocity = new Vector2(0, Input.GetAxisRaw("AVertical")) * speed;
            // if (Input.GetKeyDown(KeyCode.Space))
            // {
            //     velocity = new Vector2(0, 1) * speed;
            //     audiosource.PlayOneShot(impact);
            // }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                velocity = new Vector2(0, 0) * speed;
            }
        }
        rigid.velocity = velocity;
        timer += Time.deltaTime;
    }
    public void Dead()
    {
        int time_i;
        gameObject.GetComponent<Animator>().enabled = false;
        velocity = new Vector2(-1, 1f) * speed;
        gameObject.GetComponent<SpriteRenderer>().sprite = p2;
        // gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 2f);
        canvas.SetActive(true);
        time_i = (int)timer;
        canvas.GetComponent<printTime>().printf(time_i);
        // gameObject.GetComponent<timer>().End();
        Debug.Log(gameObject.transform.rotation);
        Debug.Log(gameObject.GetComponent<SpriteRenderer>().sprite);
    }
    public enum PlayerType
    {
        A, B
    }
}
