using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Paddle_Input : MonoBehaviour
{
    public float speed;
    public float clampValue;



    // Update is called once per frame
    void Update()
    {
        MovePaddle(Input.GetAxis("Horizontal"));
    }


    public void MovePaddle(float amountToMove)
    {
        Vector3 clampedGameObjectPosition = gameObject.transform.position + new Vector3(-amountToMove * speed, 0, 0);

        clampedGameObjectPosition.x = Mathf.Clamp(clampedGameObjectPosition.x, -clampValue, clampValue);

        gameObject.transform.position = clampedGameObjectPosition;
    }
}
