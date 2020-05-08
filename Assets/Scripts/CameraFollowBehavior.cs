using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBehavior : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target)
            transform.position = new Vector3(target.position.x, transform.position.y, target.position.z);
    }
}
