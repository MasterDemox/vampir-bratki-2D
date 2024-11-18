using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackDamage = 100f; // Урон, который наносит персонаж
    public EnemyAI enemy; // Ссылка на врага

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Например, при нажатии пробела
        {
            Attack();
        }
    }

    void Attack()
    {
        if (enemy != null)
        {
            enemy.TakeDamage(attackDamage); // Наносим урон врагу
        }
    }
}