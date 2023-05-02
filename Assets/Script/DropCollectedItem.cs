using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCollectedItem : MonoBehaviour
{
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
        if ((other.gameObject.layer == 3 || other.gameObject.layer == 8) && GameManager.instance.collectedItems == 5)
        {
            GameManager.instance.collectedItems = 0;
            Debug.Log("items get 0");
            Instantiate(GameManager.instance.moneyPref, new Vector3(-14.5f, Random.Range( 0.4f, 0.65f), -6f), Quaternion.identity);
        }
    }
}
