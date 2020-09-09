using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topicShow3 : MonoBehaviour
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
        //show出題目{
        if (other.gameObject.CompareTag("Player"))
        {
            player = GameObject.Find("Player2");
            GameObject abc;
            abc = Instantiate(GameObject.Find("Wall3(Clone)").GetComponent<ScenesRandomForLevel3>().topics[GameObject.Find("Walls3(Clone)").GetComponent<ScenesRandomForLevel3>().topic], new Vector3(player.transform.position.x + 1f, player.transform.position.y + 1f, 0), new Quaternion(0, 90, 0, 0));
            abc.transform.parent = GameObject.Find("Player2").transform;
        }

    }
}
