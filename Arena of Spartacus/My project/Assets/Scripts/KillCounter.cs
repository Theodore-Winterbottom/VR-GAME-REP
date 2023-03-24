using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.UIElements;

public class KillCounter : MonoBehaviour
{
    public TextMeshProUGUI killCounterText;

    public int kills;

    public GameObject enemy;

    public float health;

    public float SetMaxHealth;



    // When the player is hit by an enemy player takes damage
    private void OnCollisionEnter(Collision collision)
    {
        // Player deals damage to enemy if plyer hits enemy
        if (collision.gameObject.tag == "Enemy")
        {

            Destroy(enemy);
            kills++;
            killCounterText.text = "Enemy Killed" + kills;

        }
    }
}
