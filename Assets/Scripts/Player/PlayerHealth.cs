using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = FindObjectOfType<HealthBar>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

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
            healthBar.SetHealth(currentHealth);
            if(currentHealth > 100)
            {
                currentHealth = 100;
                healthBar.SetHealth(currentHealth);
            }
        }
        else
        {
            return;
        }
    }
}
