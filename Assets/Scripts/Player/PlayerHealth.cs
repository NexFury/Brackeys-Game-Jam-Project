using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
