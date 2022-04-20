using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody myRigid; // player �̵��� ���� ����
    public Animator animator; // animation ����� ���� ����
    public bool lp = false;
    public bool mv = false;    

    void Start()
    {
        myRigid = GetComponent<Rigidbody>(); // player �̵��� ���� �ʱ� ����
        animator = GetComponent<Animator>(); // animation ����� ���� �ʱ� ����
    }

    void Update()
    {

        float moveZ = 0f; // Z�� �ʱ�ȭ

        RotatePlayer(new Vector3(0f, 180, 0f));

            if (Input.GetKey(KeyCode.W)) // w�� ������ ��
            {

            }

            if (Input.GetKey(KeyCode.S)) // s�� ������ ��
            {

            }

            if (Input.GetKey(KeyCode.A)) // a�� ������ ��
            {
                moveZ -= 0.2f;  // x������ ����
                animator.SetBool("run", true); // Walking �ִϸ��̼� ����
            }
            else if (Input.GetKey(KeyCode.D))// d�� ������ ��
            {
                moveZ += 0.2f; // Z������ ����
                animator.SetBool("run", true); // Walking �ִϸ��̼� ����
            } else
            {
                animator.SetBool("run", false); // Walking �ִϸ��̼� ����� Ready Idle �ִϸ��̼� ����
            }

        if (Input.GetKey(KeyCode.J))
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                mv = true; 
                animator.SetBool("punchL", true);
            }
        }
        else
        {
            animator.SetBool("punchL", false);
        }

        
        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Punching(Left)"))
        {
            mv = false;
        }

        transform.Translate(new Vector3(0f, 0f, moveZ) * 0.1f); // Ű���带 ������ �� �����̴� ����
    }

    public void RotatePlayer(Vector3 rotation)
    {
        transform.rotation = Quaternion.Euler(rotation);
    }
}
