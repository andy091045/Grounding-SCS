using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class printTime : MonoBehaviour
{

    public Text time1_UI;
    public Text time2_UI;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void printf(float f)
    {

        time1_UI.text = "END!";
        time2_UI.text = f.ToString() + "s";

    }
}
