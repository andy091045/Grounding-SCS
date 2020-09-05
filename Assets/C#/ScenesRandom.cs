using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ScenesRandom : MonoBehaviour
{
    List<GameObject> pillars = new List<GameObject>();       //柱子隨機
    List<string> topics = new List<string>();                      //題目的物件
    List<GameObject> answerColor = new List<GameObject>();        //選項顏色的物件List
    GameObject[] options = new GameObject[2];
    public GameObject colorPoint;
    public GameObject pillar;
    public GameObject pillar1;
    public GameObject pillar2;
    public GameObject optionColor;
    public GameObject optionColor1;
    public GameObject optionColor2;
    public GameObject main;
    private float x = -70;
    public int answer = 0;
    System.Random ran;

    // Start is called before the first frame update
    void Start()
    {
        pillars.Add(pillar);
        pillars.Add(pillar1);
        pillars.Add(pillar2);

        topics.Add("紅+黃");
        topics.Add("紅+綠");
        topics.Add("黃+綠");

        answerColor.Add(optionColor);
        answerColor.Add(optionColor1);
        answerColor.Add(optionColor2);

        ScenesBuild();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(main.transform.position.x);
        if (main.transform.position.x < x)
        {
            //生成新場景  刪除舊場景
            int childCount = main.transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                Destroy(main.transform.GetChild(i).gameObject);
            }
            ScenesBuild();
            x -= 70;
        }
    }

    void ScenesBuild()
    {
        ran = new System.Random(System.Guid.NewGuid().GetHashCode());

        GameObject ab;
        ab = Instantiate(colorPoint, new Vector3(-10f, 0, 0), new Quaternion(0, 90, 0, 0));          //生成顏色顯示
        ab.transform.parent = main.transform;

        int i;
        float x = 10f;
        for (i = 0; i < 3; i++)
        {
            //int pillarNum = Random.Range(0,3);
            int pillarNum = ran.Next(3);
            GameObject a;
            a = Instantiate(pillars[pillarNum], new Vector3(x, 0, 0), new Quaternion(0, 90, 0, 0));          //生成柱子
            a.transform.parent = main.transform;
            x += 10f;
        }

        int topic = ran.Next(3);
        //int topic = Random.Range(0,3);                                                   //生成題目

        options[0] = (answerColor[topic]);
        int optionWrong = ran.Next(3);
        while (optionWrong == topic)                                                         //另外一個選項和答案重複就一直隨機到沒重複
        {
            optionWrong = ran.Next(3);
        }
        options[1] = (answerColor[optionWrong]);                                              //兩個選項新增完成

        int firstOption = ran.Next(2);
        if (firstOption == 0)                                                                //上面的是答案
        {
            GameObject a;
            a = Instantiate(options[0], new Vector3(40, 5, 0), new Quaternion(0, 90, 0, 0));
            a.transform.parent = main.transform;
            GameObject b;
            b = Instantiate(options[1], new Vector3(40, -5, 0), new Quaternion(0, 90, 0, 0));
            b.transform.parent = main.transform;
            answer = 0;
        }
        else                                                                                //下面的是答案
        {
            GameObject a;
            a = Instantiate(options[1], new Vector3(40, 5, 0), new Quaternion(0, 90, 0, 0));
            a.transform.parent = main.transform;
            GameObject b;
            b = Instantiate(options[0], new Vector3(40, -5, 0), new Quaternion(0, 90, 0, 0));
            b.transform.parent = main.transform;
            answer = 1;
        }
    }
}
