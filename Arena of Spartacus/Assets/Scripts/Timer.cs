using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Timer : MonoBehaviour
{
    // Timer text display
    public TextMeshProUGUI timerText;
    // Timer Variable
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        // Timer starts at zero
        timer = 0f;
        // Ativates UpdateTimer method
        UpdateTimer();
    }
    // Updates every frame
    private void Update()
    {
        // Incresses time by 1 sec
        timer += Time.deltaTime;
        // Ativates UpdateTimer method
        UpdateTimer();
    }
    // Method adds time
    void UpdateTimer()
    {
        // Time Variables
        hours: minuts: seconds :

        // Updates the timer display
        int hours = Mathf.FloorToInt(timer / 60f);
        int minuts = Mathf.FloorToInt(timer % 60f);
        int seconds = Mathf.FloorToInt((timer * 60f) % 60f);
        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", hours, minuts, seconds);

    }

}
