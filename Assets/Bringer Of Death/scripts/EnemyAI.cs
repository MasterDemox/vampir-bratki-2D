using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float maxHealth = 100f; // Максимальное здоровье врага
    private float currentHealth; // Текущее здоровье врага

    void Start()
    {
        currentHealth = maxHealth; // Инициализация текущего здоровья
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount; // Уменьшение здоровья
        if (currentHealth <= 0)
        {
            Die(); // Убийство врага, если здоровье меньше или равно нулю
        }
    }

    void Die()
    {
        Destroy(gameObject); // Уничтожение врага
    }
}