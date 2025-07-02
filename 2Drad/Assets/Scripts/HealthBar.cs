using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image healthImage;
    [SerializeField] private float currentHealth;
    [SerializeField] private float maxHealth;

    private float HealthCalculation() {
        float health = currentHealth /maxHealth;
        return health;
    }

    private void Update()
    {
        healthImage.fillAmount = HealthCalculation();
    }
}
