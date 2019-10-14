using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody theBod;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        //a function that gets component that it is type rigidbody
        theBod = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        //moving the rigidbody of the player
        //velocity is already built in within the rigidbody 
        theBod.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, theBod.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

        if(Input.GetButtonDown("Jump"))
        {
            //
            theBod.velocity = new Vector3(theBod.velocity.x, jumpForce, theBod.velocity.z);
        }
    }
}
