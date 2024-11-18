using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f; // ��������� �������� ��� ����� ��������� �������
    private Vector2 moveVector;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveVector = Vector2.zero; // ���������� ������ ��������

        if (Input.GetKey(KeyCode.W)) // �����
        {
            moveVector.y = 1;
        }
        if (Input.GetKey(KeyCode.S)) // ����
        {
            moveVector.y = -1;
        }
        if (Input.GetKey(KeyCode.A)) // �����
        {
            moveVector.x = -1;
        }
        if (Input.GetKey(KeyCode.D)) // ������
        {
            moveVector.x = 1;
        }

        // ����������� ������ ��������, ����� �������� ��������� ��� ������������ ��������
        if (moveVector != Vector2.zero)
        {
            moveVector.Normalize();
        }

        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
    }
}