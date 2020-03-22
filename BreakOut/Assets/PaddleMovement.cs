using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame


    void Update()
    {
        Vector2 position = this.transform.position;
        double slide = position.x;

        if (Input.GetKey(KeyCode.LeftArrow) && slide > -110)
        {
            slidePaddle(new Vector2(-50, 0));
        }

        if (Input.GetKey(KeyCode.RightArrow) && slide < 110)
        {
            slidePaddle(new Vector2(50, 0)); 
        }

    }

    void slidePaddle(Vector2 direction)
    {
        transform.Translate(direction * Time.deltaTime);
    }

}