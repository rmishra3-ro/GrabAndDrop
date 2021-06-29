using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;
    public CharacterController control;
    Vector3 velocity;
    public float fall = -8f;

    // Update is called once per frame
    

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.5f){
            control.Move(direction*playerSpeed*Time.deltaTime);
        }

        velocity.y += fall * Time.deltaTime;

        control.Move(velocity* Time.deltaTime);


    }

    void OnCollisionEnter() {
        Debug.Log("coll.collider.name");
    }
        


    
}
