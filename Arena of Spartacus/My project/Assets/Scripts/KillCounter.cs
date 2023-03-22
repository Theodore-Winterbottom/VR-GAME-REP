using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{
    public TextMeshProUGUI killCounterText;

    public int kills;

    public GameObject enemy;



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
        Destroy(enemy);
        kills++;
        killCounterText.text = "Enemy Killed" + kills;
    }
}
