using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update  
    [SerializeField]float MoveSpeed = 10f;

    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
         
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move with WASD!");
        Debug.Log("Dont Hit the Walls!");
    }

    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(xValue,0,zValue);

    }

}
