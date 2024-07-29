using MoreMountains.Feedbacks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private float countDownTime = 270f; // 4 minutos y 30 segundos
    [SerializeField] GameObject nick;
    [SerializeField] GameObject nickViejo;
    [SerializeField] GameObject final;
    [SerializeField] GameObject mambo;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float timePassed = Time.time - startTime;
        float timeLeft = countDownTime - timePassed;

        if (timeLeft <= 0)
        {
            Application.Quit();
        }
        else
        {
            int minutes = Mathf.FloorToInt(timeLeft / 60);
            int seconds = Mathf.FloorToInt(timeLeft % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

            if (timeLeft <= 142)
            {
                nick.SetActive(true);
            }
            if (timeLeft <= 104)
            {
                nickViejo.SetActive(true);
            }
            if (timeLeft <= 52)
            {
                final.SetActive(true);
            }
            if (timeLeft <= 16)
            {
                mambo.SetActive(true);
            }
        }
    }
}
