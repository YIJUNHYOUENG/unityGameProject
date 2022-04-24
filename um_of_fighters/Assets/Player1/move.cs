using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody myRigid; // player �̵��� ���� ����
    public Animator animator; // animation ����� ���� ����
    public bool lp = false;
    public bool mv = false;
    Vector3 pos;

    void Start()
    {
        myRigid = GetComponent<Rigidbody>(); // player �̵��� ���� �ʱ� ����
        animator = GetComponent<Animator>(); // animation ����� ���� �ʱ� ����
        pos = this.gameObject.transform.position;
    }

    void Update()
    {

        float moveZ = 0f; // Z�� �ʱ�ȭ

        RotatePlayer(new Vector3(0f, 180, 0f));


        
            if (Input.GetKey(KeyCode.W)) // w�� ������ ��
            {
                animator.SetBool("jump", true);
                Debug.Log("jump");
            }

            if (Input.GetKey(KeyCode.S)) // s�� ������ ��
            {

            }

            if (Input.GetKey(KeyCode.A)) // a�� ������ ��    
            {
                moveZ -= 0.2f;  // x������ ����
                animator.SetBool("run", true); // Walking �ִϸ��̼� ����
                pos = this.gameObject.transform.position;
            }
            else if (Input.GetKey(KeyCode.D))// d�� ������ ��
            {
                moveZ += 0.2f; // Z������ ����
                animator.SetBool("run", true); // Walking �ִϸ��̼� ����
                pos = this.gameObject.transform.position;
            } else
            {
                animator.SetBool("run", false); // Walking �ִϸ��̼� ����� Ready Idle �ִϸ��̼� ����
                animator.SetBool("jump", false);
                mv = false;
                transform.position = new Vector3(pos.x, pos.y, pos.z);
           
        }

        if (Input.GetKey(KeyCode.J))
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                pos = this.gameObject.transform.position;
                RotatePlayer(new Vector3(0f, 170, 0) * Time.deltaTime);
                animator.SetBool("punchL", true);
                Debug.Log("punch");
            }
        }
        else
        {
            animator.SetBool("punchL", false);
        }

        transform.Translate(new Vector3(0f, 0f, moveZ) * 0.1f); // Ű���带 ������ �� �����̴� ����
    }

    public void RotatePlayer(Vector3 rotation)
    {
        transform.rotation = Quaternion.Euler(rotation);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Capsule"))
        {
            Debug.Log("1");
        }
    }
}
