using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject tempObject;
    public Rigidbody ballRb;
    public Rigidbody tempRb;
    public Transform[] spawnTransforms;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
           int aRandomNum = GetRandomNumber();
            tempObject = Instantiate(objectToSpawn, spawnTransforms[aRandomNum].position, Quaternion.identity ); 

            //Invoke("TurnOffObject", 1.0f);

        
        
        }
        if (Input.GetKeyDown(KeyCode.F)) { tempRb = Instantiate(ballRb);}
    }
    public void TurnOffObject() 
    {
        tempObject.SetActive(false);   
    
    }

    public int GetRandomNumber() 
    {
        int randomNumber = Random.Range(0,spawnTransforms.Length);
        return randomNumber;
    
    }


}
