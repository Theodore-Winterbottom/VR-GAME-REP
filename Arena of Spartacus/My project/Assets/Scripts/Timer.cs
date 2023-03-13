using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timerText;

    public float currentTime = 1;
    public int countUp;


    // Start is called before the first frame update
    void Start()
    {
        // Repeats IEnumerator Time method
        StartCoroutine(Time());
    }

    IEnumerator Time()
    {
        // Anything under will start every second
        yield return new WaitForSeconds(1);
        
        if (currentTime == 0)
        {
            currentTime += countUp++;
        }
        


        // Anything above will start every second and repeat
        StartCoroutine(Time());
    }

    

}
