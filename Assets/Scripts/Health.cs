using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth;
    [SerializeField] TMP_Text hpDisplay;
    public string updateReason;
    public bool isAlive;
    private Death deathScript;
    void Start()
    {
        maxHealth = 200;
        health = 75;
        hpDisplay.text = health.ToString() + "/" + maxHealth.ToString();
        deathScript = GetComponent<Death>();
    }
    public void updateHP()
    {
        if (updateReason == "DarkLiquid")
        {
            health += -1;
            updateHPDisplay(health);
        }
        if (updateReason == "BossAttack")
        {
            health += -1;
            updateHPDisplay(health);
        }

        if (health <= 0)
        {
            health = 0;
            isAlive = false;
            SceneManager.LoadScene(1);
        }
    }
    void updateHPDisplay(int newHP)
    {
        hpDisplay.text = newHP.ToString() + "/" + maxHealth.ToString();
    }
}