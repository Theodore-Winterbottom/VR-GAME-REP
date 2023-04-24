using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class EnemyAi : MonoBehaviour
{

    [Header("Objects attach to player")]

    [SerializeField] public NavMeshAgent agent;

    [SerializeField] private Transform player;

    [SerializeField] private LayerMask whatIsGround, whatIsPlayer;

    [SerializeField] private Rigidbody rb;

    public float healthAmount = 100;


    [Header("States")]

    [SerializeField] private float sightRange, attackRange, rangeAttack;
    
    [SerializeField] public bool playerInSightRange, playerInAttackRange, playerInRangeAttack;

    [SerializeField] private float speed;

    //Point towards the instantiated Object will move
    Transform goal;

    //Reference to the NavMeshAgent
    UnityEngine.AI.NavMeshAgent agent1;

    // Use this for initialization
    void Start()
    {
        //You get a reference to the destination point inside your scene
        goal = GameObject.Find("Player").GetComponent<Transform>();

        //Here you get a reference to the NavMeshAgent
        agent1 = GetComponent<UnityEngine.AI.NavMeshAgent>();

        //You indicate to the agent to what position it has to move
        agent1.destination = goal.position;
    }

    public void TakeDamage(float Damage)
    {
        healthAmount -= Damage;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Sword")
        {
            TakeDamage(50);
        }
    }

    void Update()
    {
        agent1.destination = goal.position;

        if (healthAmount <= 0)
        {
            Destroy(gameObject);
        }

    }

    public void FixedUpdate()
    {
        //Check for sight and attack range
        

        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);
        playerInRangeAttack = Physics.CheckSphere(transform.position, rangeAttack, whatIsPlayer);


        //chases player if it is in the dection field
        if (playerInSightRange && !playerInAttackRange)
        {
            //ChasePlayer();
            


        }

        //Attacks player if it is in range
        if (playerInSightRange && playerInAttackRange)
        {
            //AttackPlayer();
        }
        
    }


    /*public void ChasePlayer()
    {
        Debug.Log("Hi");
        //Chases the player as long as it is in range
        agent.SetDestination(player.position);
        transform.LookAt(player);

       
    }*/

    public void AttackPlayer()
    {
        //Moves towards the player to perform a attack
        //agent.SetDestination(transform.position);

    }

    public void Death()
    {
        //Kills the emeny when health reachs zero
        Destroy(gameObject);
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, sightRange);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, rangeAttack);

    }

}
