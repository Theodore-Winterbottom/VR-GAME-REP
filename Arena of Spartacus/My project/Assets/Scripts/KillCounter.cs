using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{
    public Text killCounterText;

    public int killCounter;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        
    }

    private void ShowKills()
    {
        killCounterText.text = killCounter.ToString();
    }

    private void AddKills()
    {
        
    }

}
