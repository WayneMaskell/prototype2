using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    //Declare variables.
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    public float zRange = 10;
    public Vector3 moveDirection;
    public GameObject projectilePrefab;
    public Collider playerCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");// get  horizontal input axis
        verticalInput = Input.GetAxis("Vertical");// get vertical input axis
                                                 
        MovePlayer();

        BoundsApply();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        }

        OnTriggerEnter(playerCollider);

        

    }

    private void BoundsApply()
    {
        //bounds for x axis
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //bounds for z axis
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);

        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);


        }
    }

    private void MovePlayer()//move player with both axis
    {
        moveDirection = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate(moveDirection.normalized * speed * Time.deltaTime);
    }
    public void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Animal")) 
        {
            Debug.Log("Player Death");
        
        
        
        }
    }
   
}
