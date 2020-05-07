using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * A MonoBehavior that rotates the GameObject at a specified rate.
 **/
public class RotateBehavior : MonoBehaviour
{
    /**
     * The rate to rotate the GameObject.
     **/
    public float rate = 0.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rate);
    }
}
