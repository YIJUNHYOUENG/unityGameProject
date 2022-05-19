using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_test : MonoBehaviour
{
    private Rigidbody myRigid; // player 이동을 위한 변수
    public Animator animator; // animation 사용을 위한 변수
    public bool lp = false;
    public bool mv = false;
    Vector3 pos;

    void Start()
    {
        myRigid = GetComponent<Rigidbody>(); // player 이동을 위한 초기 설정
        animator = GetComponent<Animator>(); // animation 사용을 위한 초기 설정
        pos = this.gameObject.transform.position;
    }

    void Update()
    {

        float moveZ = 0f; // Z값 초기화

        RotatePlayer(new Vector3(0f, 180, 0f));



        if (Input.GetKey(KeyCode.W)) // w를 눌렀을 때
        {
            animator.SetBool("jump", true);
            Debug.Log("jump");
        } else
        {
            animator.SetBool("jump", false);
        }

        if (Input.GetKey(KeyCode.S)) // s를 눌렀을 때
        {
            animator.SetBool("sit", true);
            Debug.Log("sit");
        }
        else
        {
            animator.SetBool("sit", false);
        }

        if (Input.GetKey(KeyCode.A)) // a를 눌렀을 때    
        {
            moveZ -= 0.2f;  // x축으로 감소
            animator.SetBool("run", true); // Walking 애니메이션 실행
            pos = this.gameObject.transform.position;
        }
        else if (Input.GetKey(KeyCode.D))// d를 눌렀을 때
        {
            moveZ += 0.2f; // Z축으로 증가
            animator.SetBool("run", true); // Walking 애니메이션 실행
            pos = this.gameObject.transform.position;
        }
        else
        {
            animator.SetBool("run", false); // Walking 애니메이션 종료와 Ready Idle 애니메이션 실행
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
                Debug.Log("punchL");
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
                pos = this.gameObject.transform.position;
                RotatePlayer(new Vector3(0f, 170, 0) * Time.deltaTime);
                animator.SetBool("punchR", true);
                Debug.Log("punchR");
            }
        }
        else
        {
            animator.SetBool("punchR", false);
        }

        if (Input.GetKey(KeyCode.L))
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                pos = this.gameObject.transform.position;
                RotatePlayer(new Vector3(0f, 170, 0) * Time.deltaTime);
                animator.SetBool("guard", true);
                Debug.Log("guard");
            }
        }
        else
        {
            animator.SetBool("guard", false);
        }

        if (Input.GetKey(KeyCode.U))
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                pos = this.gameObject.transform.position;
                RotatePlayer(new Vector3(0f, 170, 0) * Time.deltaTime);
                animator.SetBool("kickL", true);
                Debug.Log("kickL");
            }
        }
        else
        {
            animator.SetBool("kickL", false);
        }

        if(Input.GetKey(KeyCode.I))
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                pos = this.gameObject.transform.position;
                RotatePlayer(new Vector3(0f, 170, 0) * Time.deltaTime);
                animator.SetBool("kickR", true);
                Debug.Log("kickR");
            }
        }
        else
        {
            animator.SetBool("kickR", false);
        }

        if (Input.GetKey(KeyCode.O))
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                pos = this.gameObject.transform.position;
                RotatePlayer(new Vector3(0f, 170, 0) * Time.deltaTime);
                animator.SetBool("ultimate", true);
                Debug.Log("ultimate");
            }
        }
        else
        {
            animator.SetBool("ultimate", false);
        }

        transform.Translate(new Vector3(0f, 0f, moveZ) * 0.1f); // 키보드를 눌렀을 때 움직이는 문장
    }

    public void RotatePlayer(Vector3 rotation)
    {
        transform.rotation = Quaternion.Euler(rotation);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Capsule"))
        {
            Debug.Log("1");
        }
    }
}
