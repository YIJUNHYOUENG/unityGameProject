using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody myRigid; // player 이동을 위한 변수
    public Animator animator; // animation 사용을 위한 변수
    public bool lp = false;
    public bool mv = false;    

    void Start()
    {
        myRigid = GetComponent<Rigidbody>(); // player 이동을 위한 초기 설정
        animator = GetComponent<Animator>(); // animation 사용을 위한 초기 설정
    }

    void Update()
    {

        float moveZ = 0f; // Z값 초기화

        RotatePlayer(new Vector3(0f, 180, 0f));

            if (Input.GetKey(KeyCode.W)) // w를 눌렀을 때
            {

            }

            if (Input.GetKey(KeyCode.S)) // s를 눌렀을 때
            {

            }

            if (Input.GetKey(KeyCode.A)) // a를 눌렀을 때
            {
                moveZ -= 0.2f;  // x축으로 감소
                animator.SetBool("run", true); // Walking 애니메이션 실행
            }
            else if (Input.GetKey(KeyCode.D))// d를 눌렀을 때
            {
                moveZ += 0.2f; // Z축으로 증가
                animator.SetBool("run", true); // Walking 애니메이션 실행
            } else
            {
                animator.SetBool("run", false); // Walking 애니메이션 종료와 Ready Idle 애니메이션 실행
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

        transform.Translate(new Vector3(0f, 0f, moveZ) * 0.1f); // 키보드를 눌렀을 때 움직이는 문장
    }

    public void RotatePlayer(Vector3 rotation)
    {
        transform.rotation = Quaternion.Euler(rotation);
    }
}
