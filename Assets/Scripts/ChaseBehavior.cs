using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/**
 * A MonoBehavior that causes the GameObject to move towards the nearest
 * of any number of targets using the NavMesh.
 **/
 [RequireComponent(typeof(NavMeshAgent))]
public class ChaseBehavior : MonoBehaviour
{
    /**
     * The list of transforms this GameObject will attempt to reach.
     **/
    public Transform[] targets;
    /**
     * The maximum distance this GameObject will attempt to seek targets
     */
    public float sight = 20.0f;

    private NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //Do not update if there are no targets
        if (targets.Length <= 0)
            return;

        //Set the default target to nothing
        Transform closestTarget = null;
        //Set the maximum distance to sight range
        float shortestDistance = sight;
        //Set the default path to empty
        NavMeshPath path = new NavMeshPath();

        foreach (Transform target in targets)
        {
            if (!target)
                continue;

            //Find the distance to the current target
            float distance = (target.position - transform.position).magnitude;
            
            //Check if the current target is closer than the previous closest
            if (distance < shortestDistance)
            {
                //The current target is the closest so far
                closestTarget = target;
                shortestDistance = distance;
            }
        }

        //Navigate to the closest target
        if (closestTarget)
            nav.SetDestination(closestTarget.position);
    }
}
