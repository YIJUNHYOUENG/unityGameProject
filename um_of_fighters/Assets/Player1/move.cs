using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody myRigid; // player �̵��� ���� ����
    public Animator animator;

    void Start()
    {
        myRigid = GetComponent<Rigidbody>(); // player �̵��� ���� �ʱ� ����
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        float moveZ = 0f; // Z�� �ʱ�ȭ
        float moveX = 0f; // X�� �ʱ�ȭ

        if (Input.GetKey(KeyCode.W)) // w�� ������ ��
        {

        }      

        if (Input.GetKey(KeyCode.S)) // s�� ������ ��
        {

        }

        if (Input.GetKey(KeyCode.A)) // a�� ������ ��
        {
            moveX += 0.2f;  // X������ ����
            animator.SetBool("run", true);
        } else if (Input.GetKey(KeyCode.D))// d�� ������ ��
        {
            moveX -= 0.2f; // X������ ����
            animator.SetBool("run", true);
        } else
        {
            animator.SetBool("run", false);
        }

        transform.Translate(new Vector3(moveX, moveZ, 0f) * 0.1f); // Ű���带 ������ �� �����̴� ����
    }
}

