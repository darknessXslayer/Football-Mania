using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_Paddle_Input : MonoBehaviour
{
    public float speed;
    public float clampValue;



    // Update is called once per frame
    void Update()
    {
        MovePaddle(Input.GetAxis("Vertical2"));
    }


    public void MovePaddle(float amountToMove)
    {
        Vector3 clampedGameObjectPosition = gameObject.transform.position + new Vector3(0, 0, -amountToMove * speed);

        clampedGameObjectPosition.z = Mathf.Clamp(clampedGameObjectPosition.z, -clampValue, clampValue);

        gameObject.transform.position = clampedGameObjectPosition;
    }
}