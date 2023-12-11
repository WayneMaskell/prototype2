using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Declare variables.
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");// get input axis
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);//translate player based on input axis
       //set bounds for player
        
        if (transform.position.x < - xRange)         
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z );
        }
        if (transform.position.x > xRange) 
        { 
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); }
    }
}
