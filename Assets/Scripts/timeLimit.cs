using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeLimit : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime = 10f;
    public Text countDownText;
    public GameObject gameOverPanel;
    public AudioSource timeAudio;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = "Time Remaining: " + currentTime.ToString("0");

        if(currentTime <= 0){
            currentTime = 0;
            timeAudio.Play();
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
