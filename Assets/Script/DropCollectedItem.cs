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
            Instantiate(GameManager.instance.moneyPref, new Vector3(-41.5f, Random.Range( 0.55f, 0.9f), -19f), Quaternion.identity);
            AudioManeger.Instance.BoneCollectdSfx();
            
        }
    }
}
