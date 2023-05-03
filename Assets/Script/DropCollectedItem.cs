using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCollectedItem : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.layer == 3 || other.gameObject.layer == 8) && GameManager.instance.collectedItems == 5)
        {
            GameManager.instance.collectedItems = 0;
            Debug.Log("items get 0");
            GameManager.instance.enemyDead.text = "Enemy: 0";
            Instantiate(GameManager.instance.moneyPref, new Vector3(-14.5f, Random.Range( 0.4f, 0.65f), -6f), Quaternion.identity);
            
        }
    }
}
