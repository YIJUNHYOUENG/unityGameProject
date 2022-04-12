using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody myRigid; // player 이동을 위한 변수

    void Start()
    {
        myRigid = GetComponent<Rigidbody>(); // player 이동을 위한 초기 설정
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
        }

        if (Input.GetKey(KeyCode.D))// d를 눌렀을 때
        {
            moveX -= 0.2f; // X축으로 감소
        }

        transform.Translate(new Vector3(moveX, moveZ, 0f) * 0.1f); // 키보드를 눌렀을 때 움직이는 문장
    }
}

