using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 1.0f;
    public float turnspeed = 100.0f;
    public float verticalInput;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
       // horizontalInput = Input.GetAxis("Horizontal");
        //verticalInput = Input.GetAxis("Vertical");



        transform.Translate(Vector3.forward * Time.deltaTime * speed );
        if (Input.GetKey("up")) {
            transform.Rotate(Vector3.left * Time.deltaTime * turnspeed);
        }
        else if (Input.GetKey("down"))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * turnspeed);
        }
        


    }
}
