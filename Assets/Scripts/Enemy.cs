using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("food")) 
        {
            DealDamage(other.GetComponent<ObjectSpawnItem>().damageAmount);
            Debug.Log("dealing Damage, health is now  " + enemyHealth);
            
            

        
        
        }
    }

    public void DealDamage(int damageAmount)
    {
        if (enemyHealth > 0) { enemyHealth -= damageAmount; }
        if (enemyHealth <= 0) { Die(); }

        
            

        
   }
    public void Die() { Destroy(gameObject);}
}
