using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public int monocleCounter = 0;
    public MonocleMeter monocleMeter;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = FindObjectOfType<HealthBar>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        monocleMeter = FindObjectOfType<MonocleMeter>();
        monocleMeter.UpdateMonocleMeter(monocleCounter); 
    }

    public void IncrementMonocleMeter(int monocleShard)
    {
        if(monocleCounter > 3)
        {
            monocleCounter = 3;
            monocleMeter.UpdateMonocleMeter(monocleCounter);
        }
        else
        {
            monocleCounter += monocleShard;
            monocleMeter.UpdateMonocleMeter(monocleCounter);
        }
    }

    public void MonocleDestroyed()
    {
        monocleCounter = 0;
        monocleMeter.UpdateMonocleMeter(monocleCounter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if(currentHealth < 50)
        {
            MonocleDestroyed();
        }

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
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
