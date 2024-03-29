using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed;
    bool movingLeft = true;
    bool firstInput = true;

   

    // Update is called once per frame
    void Update()
    {
        if ((GameManager.Instance.gameStarted))
        {
            Move();
            CheckInput();
        }

    }

    void Move()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

    private void CheckInput()
    {
        // ignore first mouse click
        if (firstInput)
        {
            firstInput = false;
            return; // this is the most important thing because after this next will not execute and ignoring first click is accompalished
        }
        if (Input.GetMouseButtonDown(0))
        {
            ChangeDirection();
        }

    }

    void ChangeDirection()
    {
        if (movingLeft)
        {
            movingLeft = false;
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);

        }

    else
        {
            movingLeft = true;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

    }

}
