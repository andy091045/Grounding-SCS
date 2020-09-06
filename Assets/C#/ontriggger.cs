using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ontriggger : MonoBehaviour
{
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
            GameObject player = GameObject.Find("Player2");
            player.GetComponent<PlayerMovement2>().Dead();
        }

    }
}
