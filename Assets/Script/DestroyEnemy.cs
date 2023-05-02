using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 7 && GameManager.instance.collectedItems < 5)
        {
            
            Destroy(collision.gameObject);
            Debug.Log("Destroy");
            GameManager.instance.collectedItems++;
            Debug.Log(GameManager.instance.collectedItems);
        }
        
    }
}
