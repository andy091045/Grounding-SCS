using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorOption : MonoBehaviour
{
    GameObject main;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("Walls 1");
        player = GameObject.Find("Player2");
    }

    // Update is called once per frame
    void Update()
    {

    }


    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if (main.GetComponent<ScenesRandom>().answer == 0)
        {
            if (player.transform.position.y > 0)
            {
                main.GetComponent<wall>().speed -= 1f;
                Destroy(this.gameObject);
            }
            else
            {
                main.GetComponent<wall>().speed += 3f;
                Destroy(this.gameObject);
            }
        }
        else
        {
            if (player.transform.position.y > 0)
            {
                main.GetComponent<wall>().speed += 1f;
                Destroy(this.gameObject);
            }
            else
            {
                main.GetComponent<wall>().speed -= 3f;
                Destroy(this.gameObject);
            }
        }
        int childCount = GameObject.Find("Player2").transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Destroy(GameObject.Find("Player2").transform.GetChild(i).gameObject);
        }
    }
}
