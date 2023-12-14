using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int playerLives = 0;
    public int playerScore = 0;
    

    // Start is called before the first frame update
    void Start()
    {
           
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerScore); 
        
    }

    


}
