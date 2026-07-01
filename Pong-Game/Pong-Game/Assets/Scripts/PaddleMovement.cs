using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class PaddleMovement : MonoBehaviour
{
    public float speed = 15f;
    public string inputAxis = "Vertical"; // W/S for left, Up/Down for right

    void Update()
    {
        float move = Input.GetAxis(inputAxis) * speed * Time.deltaTime;
        transform.Translate(0, move, 0);
    }
}
