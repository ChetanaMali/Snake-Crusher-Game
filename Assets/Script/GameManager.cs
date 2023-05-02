using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Player Navemesh Variable
    [Header ("Player Navmesh Variable")]
    public LayerMask whatIsEnemy;
    public GameObject destination;
    public float sightRange;
    public float enemyMoveSpeed;

    [Header("SnakeMovement Variable")]
    [HideInInspector] public int collectedItems = 0;

    [Header ("Collecte Money")]
    public GameObject moneyPref;
    

    private static GameManager Instance;
    public static GameManager instance { get { return Instance; } }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
}
