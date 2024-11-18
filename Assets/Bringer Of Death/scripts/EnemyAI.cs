using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float maxHealth = 100f; // ������������ �������� �����
    private float currentHealth; // ������� �������� �����

    void Start()
    {
        currentHealth = maxHealth; // ������������� �������� ��������
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount; // ���������� ��������
        if (currentHealth <= 0)
        {
            Die(); // �������� �����, ���� �������� ������ ��� ����� ����
        }
    }

    void Die()
    {
        Destroy(gameObject); // ����������� �����
    }
}