using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays2 : MonoBehaviour
{
    public int number = 30;
    public List<Vector3> spawnPoints;

    public int[] students = new int[10];

    public List<int> dynamicStudents = new List<int>();

    public Transform newSpawnPositionSetter;
    // Start is called before the first frame update
    void Start()
    {
        TestListAndArray();
    }

    private void TestListAndArray()
    {
        students[8] = 12;
        students[2] = 14;
        students[4] = 30;
        students[6] = 29;

        Debug.Log("The length of our array is " + students.Length);
        Debug.Log("The length of our list is " + dynamicStudents.Count
            + " and the capacity is " + dynamicStudents.Capacity);
        dynamicStudents.Add(12);
        dynamicStudents.Add(75);
        dynamicStudents.Add(34);
        dynamicStudents.Add(7);

        Debug.Log("The length of our list is " + dynamicStudents.Count
    + " and the capacity is " + dynamicStudents.Capacity);
        dynamicStudents.Add(9);
        dynamicStudents.Add(19);
        dynamicStudents.Add(22);
        dynamicStudents.Add(46);
        Debug.Log("The length of our list is " + dynamicStudents.Count
    + " and the capacity is " + dynamicStudents.Capacity);
        dynamicStudents.Add(12);
        dynamicStudents.Add(42);
        dynamicStudents.Add(76);
        Debug.Log("The length of our list is " + dynamicStudents.Count
    + " and the capacity is " + dynamicStudents.Capacity);

        Debug.Log("The length of our list is " + dynamicStudents.Count);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            dynamicStudents.Remove(12);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            dynamicStudents.RemoveAt(2);
        }

        if (Input.GetKeyDown(KeyCode.Space))
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