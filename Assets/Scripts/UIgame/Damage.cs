using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    public GameObject turretBullet;

    public int inflictedDamage = 20;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //setup player health meter
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

   public void TakeDamage(int damage)
    {
        //change health and display the change on the meter
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            dead();
        }
        healthBar.setHealth(currentHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if you collided with the bullet you take damage
        if (collision.collider.tag == "Bullet")
        {
            TakeDamage(inflictedDamage);
        }
        else if(collision.collider.tag == "DeadZone")
        {
            TakeDamage(currentHealth);
        }
    }

    public void dead() //when the player dies the screen fades out and the level restarts
    {
        animator.SetTrigger("FadeOut");
    }

    public void heal()
    {
        //resets health
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }
}
