using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    float speed = 0.1f;
    public float gepTime = 0.05f;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //要計算時間
        if(timer>= gepTime)
        {
            transform.Translate(-0.1f,0,0);
            //transform.position.x = transform.position.x - speed;
            timer-=gepTime;
        }
        timer += Time.deltaTime;
    }
}
