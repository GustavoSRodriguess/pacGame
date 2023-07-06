using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprintScript : MonoBehaviour
{
  public bool isMoving = false;
  public float movementSpeed = 100;

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown("w"))
        {
            isMoving = true;
        }

        if(Input.GetKeyUp("w"))
        {
            isMoving = false;
        }

        if(Input.GetKey(KeyCode.LeftShift) & isMoving == true)
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
    }
}
