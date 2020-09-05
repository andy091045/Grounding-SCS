using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorOption : MonoBehaviour
{
    public GameObject main;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

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
                main.GetComponent<wall>().speed -= 1.0f;
                Debug.Log("撞到正確");
            }
            else
            {
                main.GetComponent<wall>().speed += 1.0f;
                Debug.Log("撞到錯誤");
            }
        }
        else
        {
            if (player.transform.position.y > 0)
            {
                main.GetComponent<wall>().speed += 1.0f;
                Debug.Log("撞到錯誤");
            }
            else
            {
                main.GetComponent<wall>().speed -= 1.0f;
                Debug.Log("撞到正確");
            }
        }
    }
}
