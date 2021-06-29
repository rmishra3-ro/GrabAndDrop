using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class enemyDmov : MonoBehaviour
{
    public Transform player;

    
    
    

    //Transform target;
    public NavMeshAgent agent;
    //private Rigidbody R;
    // Start is called before the first frame update
   
    void Start()
    {
        
        agent = GetComponent<NavMeshAgent>();
        InvokeRepeating("SetDestination", 1.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
   
    
        
    
    
    void SetDestination() {
        agent.SetDestination(player.position);
    }
}
