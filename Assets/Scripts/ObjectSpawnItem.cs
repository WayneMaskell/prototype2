using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class ObjectSpawnItem : MonoBehaviour
{
    public int damageAmount = 5;
    public int speed = 40;
    private void Awake()
    {
        Invoke(nameof(DestroyGameObject), 2.0f); 

    }

    public void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    public void DestroyGameObject() 
    {
        Destroy(this.gameObject)    ;
    
    
    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animal"))
        {
            Destroy(gameObject);
        }
    }
}
