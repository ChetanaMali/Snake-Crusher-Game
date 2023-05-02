using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMoney : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 3 || other.gameObject.layer == 8)
        {
            Destroy(GameManager.instance.moneyPref);
            Debug.Log("Destroy Money");
        }
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Snake")
        {
            Destroy(gameObject);
            //Destroy(GameManager.instance.moneyPref);
            Debug.Log("Destroy Money");
        }
    }
}
