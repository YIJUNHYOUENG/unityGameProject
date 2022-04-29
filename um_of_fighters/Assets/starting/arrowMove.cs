using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class arrowMove : MonoBehaviour
{
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            count--;
            if(count == -1)
                count = 0;
            Debug.Log("w");
        } else if(Input.GetKeyDown(KeyCode.S))
        {
            count++;
            if (count == 3)
                count = 2;
            Debug.Log("s");
        }

        switch(count)
        {
            case 0:
                transform.position = new Vector3 (1.39f, 7.78f, 14);
                break;

            case 1:
                transform.position = new Vector3(1.39f, 6.39f, 14);
                break;

            case 2:
                transform.position = new Vector3(1.39f, 4f, 14);
                break;
        }

        if(Input.GetKey(KeyCode.J))
        {
            switch (count)
            {
                case 0:
                    SceneManager.LoadScene("1pPlay");
                    break;

                case 1:
                    SceneManager.LoadScene("2pPlay");
                    break;

                case 2:
                    SceneManager.LoadScene("option");
                    break;
            }
        }
    }
}
