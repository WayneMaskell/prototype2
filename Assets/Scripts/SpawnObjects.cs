using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public GameObject tempObject;
    public Rigidbody ballRb;
    public Rigidbody tempRb;
    public Transform[] spawnTransforms;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimals", 1.0f, 3.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V)) 
        {
           int aRandomNum = GetRandomNumber();
            int arandomAnimal = GetRandomAnimal();  
            tempObject = Instantiate(objectsToSpawn[arandomAnimal], spawnTransforms[aRandomNum].position, spawnTransforms[aRandomNum].rotation); 

            //Invoke("TurnOffObject", 1.0f);
        }
        
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
    public int GetRandomAnimal() 
    {
        int randomAnimal = Random.Range(0, objectsToSpawn.Length); 
        return randomAnimal;
    
    
    }

    public void SpawnAnimals() 
    {
        int aRandomNum = GetRandomNumber();
        int arandomAnimal = GetRandomAnimal();
        tempObject = Instantiate(objectsToSpawn[arandomAnimal], spawnTransforms[aRandomNum].position, spawnTransforms[aRandomNum].rotation);





    }


}
