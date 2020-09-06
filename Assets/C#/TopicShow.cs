using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopicShow : MonoBehaviour
{
    public float gapTime = 4;
    public float timer = 0;
    public GameObject player;
    public GameObject wall;
    public GameObject topic1;
    public GameObject topic2;
    public GameObject topic3;
    public GameObject topic4;
    public GameObject topic5;
    public GameObject topic6;
    public GameObject topic7;
    public GameObject topic8;
    public GameObject topic9;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= gapTime)
        {

            timer -= gapTime;
        }
        timer += Time.deltaTime;

    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("生成題目");
            //show出題目
            GameObject a;
            a = Instantiate(GameObject.Find("Walls 1").GetComponent<ScenesRandom>().topics[GameObject.Find("Walls 1").GetComponent<ScenesRandom>().topic], new Vector3(player.transform.position.x, player.transform.position.y, 0), new Quaternion(0, 90, 0, 0));
            a.transform.parent = GameObject.Find("Player2").transform;
        }

    }
}
