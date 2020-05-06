using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMoveBehavior : MonoBehaviour
{
    /**
     * A reference to the MoveBehavior.
     **/
    public MoveBehavior move;

    // Update is called once per frame
    void Update()
    {
        //Find the direction
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        direction.Normalize();

        //Apply the direction
        move.ApplyDirection(direction);
    }
}
