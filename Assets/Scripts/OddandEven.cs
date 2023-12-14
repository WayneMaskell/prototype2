using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OddandEven : MonoBehaviour
{
    public GameObject[] cubes;
    public Material material;
    // Start is called before the first frame update
    void Start()
    {
      

       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            LoopCubes();



        }
    }
    public void LoopCubes() 
    {
        for (int i = 0; i < cubes.Length; i += 2) 
        {
            cubes[i].GetComponent<MeshRenderer>().material = material;
        
        
        }  
    
    
    
    }
    public void FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            if ((i % 3 == 0) && (i % 5 == 0))
            { Debug.Log("FizzBuzz\n"); }
            else if (i % 3 == 0)
            { Debug.Log("fizz"); }
            else if (i % 5 == 0)
            { Debug.Log("buzz"); }
            else
            {
                Debug.Log(i);
            }

        }
    }
    
        
    


}
