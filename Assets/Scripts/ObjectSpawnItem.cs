using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class ObjectSpawnItem : MonoBehaviour
{
    private void Awake()
    {
        Invoke(nameof(DestroyGameObject), 2.0f); 
    }
    public void DestroyGameObject() 
    {
        Destroy(this.gameObject)    ;
    
    
    
    }
}
