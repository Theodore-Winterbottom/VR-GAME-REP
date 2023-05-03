using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using static UnityEngine.GraphicsBuffer;

public class EnemyAi : MonoBehaviour
{

    [Header("Objects attach to player")]

    //[SerializeField] public NavMeshAgent agent;

    [SerializeField] private Transform player;

    [SerializeField] private LayerMask whatIsGround, whatIsPlayer;

    [Header("States")]

    [SerializeField] private float sightRange, attackRange, rangeAttack;

    [SerializeField] public bool playerInSightRange, playerInAttackRange, playerInRangeAttack;

    [SerializeField] private float speed;

    [SerializeField] private float health;

    [SerializeField] private Rigidbody rb;

    private bool lookAt;

    public float healthAmount = 100;

    public List<Collider> colliders;

    //Point towards the instantiated Object will move
    Transform goal;

    //Reference to the NavMeshAgent
    public UnityEngine.AI.NavMeshAgent agent1;

    // Use this for initialization
    void Start()
    {
        //You get a reference to the destination point inside your scene
        goal = GameObject.Find("Player").GetComponent<Transform>();

        //Here you get a reference to the NavMeshAgent
        agent1 = GetComponent<UnityEngine.AI.NavMeshAgent>();


    }

    public void TakeDamage(float Damage)
    {
        healthAmount -= Damage;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sword")
        {
            TakeDamage(50);
        }
        if (collision.gameObject.tag == "Fist")
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {

        if (healthAmount <= 0)
        {
            Destroy(gameObject);
        }

        if (transform.position.y > .3f)
        {
            lookAt = false;
            agent1.enabled = false;
            for (int i = 0; colliders.Count == i; i++)
            {
                colliders[i].enabled = false;
            }

        }
        else
        {
            agent1.enabled = true;
            lookAt = true;
            for (int i = 0; colliders.Count == i; i++)
            {
                colliders[i].enabled = true;
            }
        }

        if (lookAt)
        {
            agent1.destination = goal.position;
            transform.LookAt(goal);
        }


    }


    private void FixedUpdate()
    {
        //Check for sight and attack range


        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);
        playerInRangeAttack = Physics.CheckSphere(transform.position, rangeAttack, whatIsPlayer);


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