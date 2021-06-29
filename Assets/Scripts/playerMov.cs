using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMov : MonoBehaviour
{
    public CharacterController control;
    public float playerSpeed = 10f;
    public float gravity = -8f;
   
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward *z;

        control.Move(move*playerSpeed*Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        control.Move(velocity * Time.deltaTime);


    }
}
