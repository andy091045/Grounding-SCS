using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topicShow2 : MonoBehaviour
{
    public GameObject player;
    public GameObject wall;
    public GameObject topic1;
    public GameObject topic2;
    public GameObject topic3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //show出題目
            GameObject a;
            a = Instantiate(GameObject.Find("Walls2").GetComponent<ScenesRandomForLevel2>().topics[GameObject.Find("Walls2").GetComponent<ScenesRandomForLevel2>().topic], new Vector3(player.transform.position.x, player.transform.position.y + 2.5f, 0), new Quaternion(0, 90, 0, 0));
            a.transform.parent = GameObject.Find("Player2").transform;
        }

    }
}
