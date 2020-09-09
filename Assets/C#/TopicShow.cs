﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopicShow : MonoBehaviour
{
    public GameObject player;
    public GameObject wall;
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
            player = GameObject.Find("Player2");
            //show出題目
            GameObject a;
            a = Instantiate(GameObject.Find("Walls 1").GetComponent<ScenesRandom>().topics[GameObject.Find("Walls 1").GetComponent<ScenesRandom>().topic], new Vector3(player.transform.position.x + 1f , player.transform.position.y + 1f , 0), new Quaternion(0, 90, 0, 0));
            a.transform.parent = GameObject.Find("Player2").transform;
        }

    }
}
