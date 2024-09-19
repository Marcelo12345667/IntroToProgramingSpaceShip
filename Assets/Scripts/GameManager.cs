using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Text timerText;
    float timer;
    public static GameManager gm;
    public bool playing;
    // Start is called before the first frame update
    void Start()
    {
        gm = this;
        timer = 0;
        playing = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (playing)
        {
            timer += Time.deltaTime;
            timerText.text = timer.ToString();
        }
    }
}
