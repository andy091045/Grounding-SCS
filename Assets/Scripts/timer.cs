﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public GameObject canvas;
    float timer1 = 0.0f;
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        //暫停用的程式碼
        // StartCoroutine(TimePause());
    }

    // Update is called once per frame
    void Update()
    {
        timer1 += Time.deltaTime;
        // Debug.Log("時間" + timer1);
    }
    public void End()
    {
        float f = timer1;

        canvas.GetComponent<printTime>().printf(f);
    }

    // IEnumerator TimePause()
    // {
    //     Debug.Log("5");
    //     yield return new WaitForSeconds(5);
    //     Debug.Log("0");
    // }
}
