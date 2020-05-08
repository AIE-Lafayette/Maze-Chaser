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

        if (Camera.main.aspect >= 1 && target)
        {
            //Camera position for landscape mode
            transform.position = new Vector3(target.position.x, 10.0f, target.position.z - 2f);
        }
        else
        {
            //Camera position for portrait mode
            transform.position = new Vector3(target.position.x, 20.0f, target.position.z - 4f);
        }
    }
}
