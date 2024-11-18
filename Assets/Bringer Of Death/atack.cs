using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player; // ������ �� ������
    public float speed = 2f; // �������� �������� �����
    public float maxHealth = 100f; // ������������ �������� �����
    private float currentHealth; // ������� �������� �����

    void Start()
    {
        currentHealth = maxHealth; // ������������� �������� ��������
    }

    void Update()
    {
        MoveTowardsPlayer();
    }

    void MoveTowardsPlayer()
    {
        // ���������� ����������� � ������
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime; // �������� �����
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