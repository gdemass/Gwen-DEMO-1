using System;
using System.Numerics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public float speed = 4;
//update is called once per frame

void Update()
    {
    //traveling up
    if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        //traveling down
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
        }
        transform.position = new UnityEngine.Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.5f, 3.5f), transform.position.z); 
    }
}
