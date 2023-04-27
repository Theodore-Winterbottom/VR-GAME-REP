using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timerText;

    public float timer;
    public int countUp = 1;

    
    

    // Start is called before the first frame update
    void Start()
    {
        // Repeats IEnumerator Time method
        //StartCoroutine(Time());
    }

    void ToStartCoroutine(int countUp)
    {
        // When Botton GameObject is pressed Timer is active
        if (gameObject.tag == ("Botton"))
        {
            // Repeats IEnumerator Time method
            StartCoroutine(Time());
        }
    }

    IEnumerator Time()
    {
        // Anything under will start every second
        yield return new WaitForSeconds(1);

        AddTime(countUp);


        // Anything above will start every second and repeat
        StartCoroutine(Time());
    }
    
    void AddTime(int countUp)
    {
        //if ()
        {
            
        }
    }

}
