using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player; // ������ �� ������
    public float speed = 2f; // �������� �������� �����
    public float teleportCooldown = 7f; // ����� �������� ��� ������������
    private float nextTeleportTime = 0f; // ����� ��������� ������������

    void Update()
    {
        // �������� ����� � ������
        MoveTowardsPlayer();

        // �������� �� ����������� ������������
        if (Time.time >= nextTeleportTime)
        {
            TeleportToPlayer();
            nextTeleportTime = Time.time + teleportCooldown; // ��������� ������� ��������� ������������
        }
    }

    void MoveTowardsPlayer()
    {
        // ���������� ����������� � ������
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime; // �������� �����
    }

    void TeleportToPlayer()
    {
        // ������������ ����� � ������� ������
        transform.position = player.position; // ����������� ����� � ������
    }
}