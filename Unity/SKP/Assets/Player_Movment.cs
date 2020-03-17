using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movment : MonoBehaviour
{


    public float Speed = 5;

  


    public void FixedUpdate()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * Time.deltaTime * Speed, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime * Speed);
    }
}
