using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player; // Ссылка на игрока
    public float speed = 2f; // Скорость движения врага
    public float maxHealth = 100f; // Максимальное здоровье врага
    private float currentHealth; // Текущее здоровье врага

    void Start()
    {
        currentHealth = maxHealth; // Инициализация текущего здоровья
    }

    void Update()
    {
        MoveTowardsPlayer();
    }

    void MoveTowardsPlayer()
    {
        // Вычисление направления к игроку
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime; // Движение врага
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