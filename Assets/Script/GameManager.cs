using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

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

    [Header("Drop Bone")]
    public Text enemyDead;

    [Header ("Collecte Money")]
    public GameObject moneyPref;
    public Text scoreText;

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
