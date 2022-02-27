using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public BossHealthBar bossHealthBar;
    // Start is called before the first frame update
    void Start()
    {
        bossHealthBar = FindObjectOfType<BossHealthBar>();
        currentHealth = maxHealth;
        bossHealthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        bossHealthBar.SetHealth(currentHealth);

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        //Animate dead state or instantiate particle splatter
        //Restart level
    }

    public void Heal(int healthPoints)
    {
        if(currentHealth < 100)
        {
            currentHealth += healthPoints;
            bossHealthBar.SetHealth(currentHealth);
            if(currentHealth > 100)
            {
                currentHealth = 100;
                bossHealthBar.SetHealth(currentHealth);
            }
        }
        else
        {
            return;
        }
    }
}
