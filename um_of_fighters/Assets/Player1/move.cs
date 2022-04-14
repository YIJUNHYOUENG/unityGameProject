using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody myRigid; // player 이동을 위한 변수
    public Animator animator;
    public bool lp = false;
    public bool mv = false;    

    void Start()
    {
        myRigid = GetComponent<Rigidbody>(); // player 이동을 위한 초기 설정
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        float moveZ = 0f; // Z값 초기화
        float moveX = 0f; // X값 초기화

        RotatePlayer(new Vector3(0f, 180, 0f));

        if(!mv) { 
            if (Input.GetKey(KeyCode.W)) // w를 눌렀을 때
            {

            }

            if (Input.GetKey(KeyCode.S)) // s를 눌렀을 때
            {

            }

            if (Input.GetKey(KeyCode.A)) // a를 눌렀을 때
            {
                moveX += 0.2f;  // X축으로 증가
                moveZ -= 0.2f;

            }
            else if (Input.GetKey(KeyCode.D))// d를 눌렀을 때
            {
                moveX -= 0.2f; // X축으로 감소
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

        transform.Translate(new Vector3(moveX, 0f, moveZ) * 0.1f); // 키보드를 눌렀을 때 움직이는 문장
    }

    public void RotatePlayer(Vector3 rotation)
    {
        transform.rotation = Quaternion.Euler(rotation);
    }
}
