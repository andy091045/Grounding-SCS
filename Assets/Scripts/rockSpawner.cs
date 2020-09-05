using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockSpawner : MonoBehaviour
{
    public GameObject cubes;
    public Transform[] points;
    public float gapTime = 4;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= gapTime)
        {
            int i = Random.Range(0, 4);
            switch (i)
            {
                case 0:
                    GameObject cube0 = Instantiate(cubes, points[0]);
                    cube0.transform.localPosition = Vector3.zero;
                    break;
                case 1:
                    GameObject cube1 = Instantiate(cubes, points[1]);
                    cube1.transform.localPosition = Vector3.zero;
                    break;
                case 2:
                    GameObject cube2 = Instantiate(cubes, points[2]);
                    cube2.transform.localPosition = Vector3.zero;
                    break;
                case 3:
                    GameObject cube3 = Instantiate(cubes, points[3]);
                    cube3.transform.localPosition = Vector3.zero;
                    break;

                default:
                    break;
            }
            timer -= gapTime;
        }
        timer += Time.deltaTime;
    }
}
