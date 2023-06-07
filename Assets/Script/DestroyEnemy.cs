using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 7 && GameManager.instance.collectedItems < 5)
        {
            
            Destroy(collision.gameObject);
            Debug.Log("Destroy");
            GameManager.instance.collectedItems++;

            GameManager.instance.enemyDead.text = "Enemy: " + GameManager.instance.collectedItems.ToString();
            Debug.Log(GameManager.instance.collectedItems);
            AudioManeger.Instance.EnemyDeadSfx();
            Instantiate(GameManager.instance.m_ParticleSystem, transform.position, Quaternion.identity);
        }
        
    }
}
