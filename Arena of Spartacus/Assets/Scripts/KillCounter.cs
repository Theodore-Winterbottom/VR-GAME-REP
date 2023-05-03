using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class KillCounter : MonoBehaviour
{
    // Kill counter text
    public TextMeshProUGUI killCounterText;
    // Kill counter variable
    public int killCount = 0;

    public int damage = 10;

    private void Start()
    {
        // 
        killCounterText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        // 
        killCounterText.text = killCount.ToString();
    }
    // Method to add kills
    void AddKills()
    {
        // Adds kills
        killCount++;
    }

    void OnTriggerEnter(Collider other)
    {
        EnemyAi enemy = other.gameObject.GetComponent<EnemyAi>();
        
        if (enemy != null)
        {
            //enemy.TakeDamage(damage);
        }
    }
































































    /*/ When the player is hit by an enemy player takes damage
    private void OnCollisionEnter(Collision collision)
    {
        // Player deals damage to enemy if plyer hits enemy
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            kills++;
            killCounterText.text = "Enemy Killed" + kills;

        }
    }

   


    /*public TextMeshProUGUI killCounterText;

    public int kills;

    public GameObject enemy;

    public float health;



    // When the player is hit by an enemy player takes damage
    private void OnCollisionEnter(Collision collision)
    {
        // Player deals damage to enemy if plyer hits enemy
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            kills++;
            killCounterText.text = "Enemy Killed" + kills;

        }






    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
    }*/
}
