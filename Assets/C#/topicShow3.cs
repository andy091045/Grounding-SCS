using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topicShow3 : MonoBehaviour
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
        //show出題目{
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject abc;
            abc = Instantiate(GameObject.Find("Walls3").GetComponent<ScenesRandomForLevel3>().topics[GameObject.Find("Walls3").GetComponent<ScenesRandomForLevel3>().topic], new Vector3(player.transform.position.x, player.transform.position.y, 0), new Quaternion(0, 90, 0, 0));
            abc.transform.parent = GameObject.Find("Player2").transform;
        }

    }
}
