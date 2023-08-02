using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavemesh : MonoBehaviour
{
    
    private NavMeshAgent navMeshAgent;
    private bool playerInSightRange;
    /*
    public LayerMask whatIsPlayer;
    public GameObject destination;

    //public float walkPointRange;
    public float sightRange;
    public float enemyMoveSpeed;
    */
  /*
    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //check range
        playerInSightRange = Physics.CheckSphere(transform.position, GameManager.instance.sightRange, GameManager.instance.whatIsEnemy);

        //
        if (!playerInSightRange) IdealEnemy();
        if (playerInSightRange) runaway();
    }
    

    void IdealEnemy()
    {
        navMeshAgent.SetDestination(transform.position);
            
     }
    void runaway()
    {
        navMeshAgent.SetDestination(GameManager.instance.destination.transform.position * GameManager.instance.enemyMoveSpeed * Time.deltaTime);
    }
     */
}
