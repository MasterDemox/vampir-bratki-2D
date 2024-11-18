using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player; // Ссылка на игрока
    public float speed = 2f; // Скорость движения врага
    public float teleportCooldown = 7f; // Время кулдауна для телепортации
    private float nextTeleportTime = 0f; // Время следующей телепортации

    void Update()
    {
        // Движение врага к игроку
        MoveTowardsPlayer();

        // Проверка на возможность телепортации
        if (Time.time >= nextTeleportTime)
        {
            TeleportToPlayer();
            nextTeleportTime = Time.time + teleportCooldown; // Установка времени следующей телепортации
        }
    }

    void MoveTowardsPlayer()
    {
        // Вычисление направления к игроку
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime; // Движение врага
    }

    void TeleportToPlayer()
    {
        // Телепортация врага к позиции игрока
        transform.position = player.position; // Перемещение врага к игроку
    }
}