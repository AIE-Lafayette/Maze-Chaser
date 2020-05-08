using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * A MonoBehavior that causes the GameObject to track the target on
 * the XZ plane.
 **/
public class FollowBehavior : MonoBehaviour
{
    /**
     * A reference to the Transform to track.
     **/
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target)
            transform.position = new Vector3(target.position.x, transform.position.y, target.position.z);
    }
}
