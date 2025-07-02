using UnityEngine;
using UnityEngine.UI;

public class HealthBarZadatak : MonoBehaviour
{
    [SerializeField] private Image healthImage;
    [SerializeField] private float currentHealth;
    [SerializeField] private float maxHealth=130;
    [SerializeField] private float damage=21;
    [SerializeField] private float heal=13;

    private void Start()
    {
        healthImage.fillAmount = HealthCalculation();
    }

    private float HealthCalculation()
    {
        float health = currentHealth / maxHealth;
        return health;
    }

    private float AddHealthCalculation()
    {
        float health = currentHealth + heal;
         health = health / maxHealth;
        return health;
    }

    private float DamageHealthCalculation()
    {
        float health = currentHealth + damage;
        health = health / maxHealth;
        return health;
    }


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.K))
        {
            currentHealth -= damage;
            healthImage.fillAmount = DamageHealthCalculation();
            if (currentHealth < 0) {
                currentHealth =0;
            }    
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentHealth += heal;
            healthImage.fillAmount = AddHealthCalculation();
            if (currentHealth >130)
            {
                currentHealth =maxHealth;
            }
        }
    }
}
