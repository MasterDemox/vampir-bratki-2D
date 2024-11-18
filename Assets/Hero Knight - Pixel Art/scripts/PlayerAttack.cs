using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackDamage = 100f; // ����, ������� ������� ��������
    public EnemyAI enemy; // ������ �� �����

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // ��������, ��� ������� �������
        {
            Attack();
        }
    }

    void Attack()
    {
        if (enemy != null)
        {
            enemy.TakeDamage(attackDamage); // ������� ���� �����
        }
    }
}