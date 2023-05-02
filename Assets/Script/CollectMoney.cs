using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CollectMoney : MonoBehaviour
{
    
    int score;
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
            score++;
            GameManager.instance.scoreText.text = "Score: " + score.ToString();
        }
    }
}
