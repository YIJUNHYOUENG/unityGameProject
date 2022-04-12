using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody myRigid; // player 이동을 위한 변수
    public Animator animator;

    void Start()
    {
        myRigid = GetComponent<Rigidbody>(); // player 이동을 위한 초기 설정
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        float moveZ = 0f; // Z값 초기화
        float moveX = 0f; // X값 초기화

        if (Input.GetKey(KeyCode.W)) // w를 눌렀을 때
        {

        }      

        if (Input.GetKey(KeyCode.S)) // s를 눌렀을 때
        {

        }

        if (Input.GetKey(KeyCode.A)) // a를 눌렀을 때
        {
            moveX += 0.2f;  // X축으로 증가
            animator.SetBool("run", true);
        } else if (Input.GetKey(KeyCode.D))// d를 눌렀을 때
        {
            moveX -= 0.2f; // X축으로 감소
            animator.SetBool("run", true);
        } else
        {
            animator.SetBool("run", false);
        }

        transform.Translate(new Vector3(moveX, moveZ, 0f) * 0.1f); // 키보드를 눌렀을 때 움직이는 문장
    }
}

