using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public Transform newSpawnPositionSetter;
    public int[] students = new int[10];
    public List<int> dynamicStudents = new List<int>();
    public List<Vector3> spawnPoints; 
    // Start is called before the first frame update
    void Start()
    {
        students[8] = 12;
        students[9] = 13;
        students[1] = 14;
        students[2] = 15;
        Debug.Log("the length of our array is " + students.Length);

        dynamicStudents.Add(12);
        dynamicStudents.Add(12);
        dynamicStudents.Add(13);
        dynamicStudents.Add(14);
        dynamicStudents.Add(15);
            
        Debug.Log("the length of our list is  " + dynamicStudents.Count + " and the Capacity is  " + dynamicStudents.Capacity);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            spawnPoints.Add(newSpawnPositionSetter.position);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            MoveSetterToPosition();
        }
    }
    public void MoveSetterToPosition()
    {
        newSpawnPositionSetter.position = spawnPoints[GetRandomNumber()];
    }

    public int GetRandomNumber()
    {
        int randomNumber = Random.Range(0, spawnPoints.Count);
        return randomNumber;
    }


}
