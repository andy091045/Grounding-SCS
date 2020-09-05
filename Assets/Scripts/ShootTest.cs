using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTest : MonoBehaviour
{

    public PlayerMovement playerMovement;
    public int speed;
    // Rigidbody2D box;
    Vector2 pos;
    public GameObject box;
    // Start is called before the first frame update
    void Start()
    {

        pos = new Vector2(1.0f, 0.0f);
        // playerMovement = gameObject.GetComponent<PlayerMovement>();
        if (playerMovement != null)
        {
            playerMovement.shoot += Shoot;
        }

    }

    private void OnDestroy()
    {
        if (playerMovement != null)
            playerMovement.shoot -= Shoot;
    }
    void Shoot(int n)
    {

        if (n == 1)
        {
            GameObject NewBox = Instantiate(box);
            NewBox.GetComponent<Rigidbody2D>().velocity = pos * speed;
        }

    }
}
