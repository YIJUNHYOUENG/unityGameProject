using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody myRigid; // player �̵��� ���� ����
    public Animator animator;
    public bool lp = false;
    public bool mv = false;    

    void Start()
    {
        myRigid = GetComponent<Rigidbody>(); // player �̵��� ���� �ʱ� ����
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        float moveZ = 0f; // Z�� �ʱ�ȭ
        float moveX = 0f; // X�� �ʱ�ȭ

        RotatePlayer(new Vector3(0f, 180, 0f));

        if(!mv) { 
            if (Input.GetKey(KeyCode.W)) // w�� ������ ��
            {

            }

            if (Input.GetKey(KeyCode.S)) // s�� ������ ��
            {

            }

            if (Input.GetKey(KeyCode.A)) // a�� ������ ��
            {
                moveX += 0.2f;  // X������ ����
                moveZ -= 0.2f;

            }
            else if (Input.GetKey(KeyCode.D))// d�� ������ ��
            {
                moveX -= 0.2f; // X������ ����
                moveZ += 0.2f;
            }
        }

        if (Input.GetKey(KeyCode.J))
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                mv = true; 
                if (false == lp)
                {
                    animator.SetBool("punchL", true);
                    lp = true;
                }
            }
            else
            {
                lp = false;
            }
        }
        else
        {
            animator.SetBool("punchL", false);
        }

        if (Input.GetKey(KeyCode.K))
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                mv = true;
                if (false == lp)
                {
                    animator.SetBool("punchR", true);
                    lp = true;
                }
            }
            else
            {
                lp = false;
            }
        }
        else
        {
            animator.SetBool("punchR", false);
        }

        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Punching(Left)"))
        {
            mv = false;
        }

        transform.Translate(new Vector3(moveX, 0f, moveZ) * 0.1f); // Ű���带 ������ �� �����̴� ����
    }

    public void RotatePlayer(Vector3 rotation)
    {
        transform.rotation = Quaternion.Euler(rotation);
    }
}
