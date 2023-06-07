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
    public int score;

    [SerializeField] GameObject m_Enemy;
    [SerializeField] float minX, maxX;
    [SerializeField] float y;
    [SerializeField] float minZ, maxZ;

    public GameObject m_ParticleSystem;

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
    #region Spawn Enemy
    private void Start()
    {
        StartCoroutine(SpawnEnemy(20f)); //Coroutine for Spawn Enemy after some time interval
    }
    private IEnumerator SpawnEnemy(float timeInterval)
    {
        while(true)
        {
            Instantiate(m_Enemy, new Vector3(Random.RandomRange(minX, maxX), y, Random.RandomRange(minZ, maxZ)),Quaternion.identity);
            Debug.Log("Enemy Instantiate");
            yield return new WaitForSeconds(timeInterval);

        }
    }
    #endregion

}
