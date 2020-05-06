using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MoveBehavior : MonoBehaviour
{
    /**
     * The magnitude of the movement vector.
     **/
    public float speed = 1.0f;

    /**
     * A reference to the CharacterController.
     **/
    public CharacterController characterController;

    /**
     * The direction of the movement vector.
     **/
    private Vector3 _direction;

    // Update is called once per frame
    void Update()
    {
        //Find the direction
        _direction.Normalize();

        //Move in the direction at the speed
        characterController.Move(_direction * speed * Time.deltaTime);

        //Reset the direction
        _direction.x = 0;
        _direction.y = 0;
        _direction.z = 0;
    }

    /**
     * Combine the input direction with the direction calculated so
     * far this Update. This is reset each Update.
     **/
    public void ApplyDirection(Vector3 direction)
    {
        _direction += direction;
    }
}
