using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option : MonoBehaviour
{
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MoveX = 0;

        pos = this.gameObject.transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            if (pos.x <= 3.9f)
                MoveX += 0.2f;
        } else if(Input.GetKey(KeyCode.A))
        {
            if (pos.x >= -3.12f)
                MoveX -= 0.2f;
        }

        transform.Translate(new Vector3(MoveX, 0f, 0f) * 0.1f);
    }
}
