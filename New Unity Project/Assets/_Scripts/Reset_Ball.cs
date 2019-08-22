using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_Ball : MonoBehaviour
{
    public static Reset_Ball instance;
    public GameObject ball;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ResetBall();
    }

    public void ResetBall()
    {
        GameObject ballClone = Instantiate(ball);
    }
}
