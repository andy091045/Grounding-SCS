using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenesRandomForLevel2 : MonoBehaviour
{
    List<GameObject> pillarsUp = new List<GameObject>();       //柱子隨機
    List<GameObject> pillarsDown = new List<GameObject>();
    public List<GameObject> topics = new List<GameObject>();                      //題目的物件
    List<GameObject> answerColor = new List<GameObject>();        //選項顏色的物件List
    GameObject[] options = new GameObject[2];
    public GameObject colorPoint;
    public GameObject cow;
    public GameObject cow2;
    public GameObject dog_catcher;
    public GameObject eagle;
    public GameObject street_light;
    public GameObject outer_cage;
    public GameObject sign;
    public GameObject telephone_pole;
    public GameObject tree1;
    public GameObject traffic_light;
    public GameObject optionColor;
    public GameObject optionColor1;
    public GameObject optionColor2;
    public GameObject optionColor3;
    public GameObject optionColor4;
    public GameObject optionColor5;
    public GameObject optionColor6;
    public GameObject optionColor7;
    public GameObject optionColor8;
    public GameObject main;
    private float x = -70;
    public int answer = 0;
    System.Random ran;
    int count = 1;
    public GameObject wall2;
    public GameObject backGround;
    public GameObject backGround2;
    public GameObject obstacle;
    public GameObject topic1;
    public GameObject topic2;
    public GameObject topic3;
    public int level = 2;
    public int topic = 0;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        pillarsDown.Add(cow2);
        pillarsDown.Add(dog_catcher);
        pillarsUp.Add(cow);
        pillarsUp.Add(eagle);
        pillarsDown.Add(outer_cage);
        pillarsDown.Add(telephone_pole);
        pillarsUp.Add(traffic_light);
        pillarsDown.Add(tree1);
        pillarsDown.Add(sign);
        pillarsDown.Add(street_light);

        topics.Add(topic1);
        topics.Add(topic2);
        topics.Add(topic3);

        answerColor.Add(optionColor);
        answerColor.Add(optionColor1);
        answerColor.Add(optionColor2);
        answerColor.Add(optionColor3);
        answerColor.Add(optionColor4);
        answerColor.Add(optionColor5);
        answerColor.Add(optionColor6);
        answerColor.Add(optionColor7);
        answerColor.Add(optionColor8);

        ScenesBuild();
    }

    // Update is called once per frame
    void Update()
    {
        if (main.transform.position.x < x)
        {
            //生成新場景  刪除舊場景
            int childCount = main.transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                Destroy(main.transform.GetChild(i).gameObject);
            }
            childCount = GameObject.Find("Player2").transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                Destroy(GameObject.Find("Player2").transform.GetChild(i).gameObject);
            }
            if (count == 10)
            {
                Instantiate(wall2, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
                Instantiate(backGround2, new Vector3(17, 0, 0), new Quaternion(0, 0, 0, 0));
                Destroy(main);
                Destroy(backGround);
            }
            ScenesBuild();
            x -= 70;
        }
    }

    void ScenesBuild()
    {

        ran = new System.Random(System.Guid.NewGuid().GetHashCode());

        GameObject ab;
        ab = Instantiate(colorPoint, new Vector3(5f, 0, 0), new Quaternion(0, 90, 0, 0));          //生成顏色顯示
        ab.transform.parent = main.transform;

        int i;
        float x = 10f;
        for (i = 0; i < 3; i++)
        {
            int upOrDown = ran.Next(2);
            if (upOrDown == 0)                   //上方障礙物
            {
                int pillarNum = ran.Next(3);
                GameObject a;
                int rotate = ran.Next(2);
                if (rotate == 0)
                {
                    a = Instantiate(pillarsUp[pillarNum], new Vector3(x, 3f, 0), new Quaternion(0, 90, 0, 0));          //生成柱子
                }
                else
                {
                    a = Instantiate(pillarsUp[pillarNum], new Vector3(x, 3f, 0), new Quaternion(0, 0, 0, 0));
                }
                a.transform.parent = main.transform;
            }
            else
            {
                int pillarNum = ran.Next(7);
                GameObject a;
                int rotate = ran.Next(2);
                if (rotate == 0)
                {
                    a = Instantiate(pillarsDown[pillarNum], new Vector3(x, -3f, 0), new Quaternion(0, 90, 0, 0));          //生成柱子
                }
                else
                {
                    a = Instantiate(pillarsDown[pillarNum], new Vector3(x, -3f, 0), new Quaternion(0, 0, 0, 0));
                }
                a.transform.parent = main.transform;
            }
            x += 10f;
        }

        topic = ran.Next(3);
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
            a = Instantiate(options[0], new Vector3(40, 2.5f, 0), new Quaternion(0, 90, 0, 0));
            a.transform.parent = main.transform;
            GameObject b;
            b = Instantiate(options[1], new Vector3(40, -2.5f, 0), new Quaternion(0, 90, 0, 0));
            b.transform.parent = main.transform;
            answer = 0;
        }
        else                                                                                //下面的是答案
        {
            GameObject a;
            a = Instantiate(options[1], new Vector3(40, 2.5f, 0), new Quaternion(0, 90, 0, 0));
            a.transform.parent = main.transform;
            GameObject b;
            b = Instantiate(options[0], new Vector3(40, -2.5f, 0), new Quaternion(0, 90, 0, 0));
            b.transform.parent = main.transform;
            answer = 1;
        }
        GameObject c;
        c = Instantiate(obstacle, new Vector3(40, 0, 0), new Quaternion(0, 0, 0, 0));
        c.transform.parent = main.transform;
        count++;
    }
}
