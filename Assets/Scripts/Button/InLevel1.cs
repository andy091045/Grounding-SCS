using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InLevel1 : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown("W"))
        // {
        //     SceneManager.LoadScene("SampleScene");
        // }
    }
    public void OnLoginButtonClick()
    {
        audiosource.PlayOneShot(impact);
        SceneManager.LoadScene(2);
    }
}
