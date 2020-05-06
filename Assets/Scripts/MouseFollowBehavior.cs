using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollowBehavior : MonoBehaviour
{
    /**
     * A reference to the MoveBehavior.
     **/
    public MoveBehavior move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //Get the mouse position
            Vector3 mousePosition = Input.mousePosition;
            //Get the ray from the camera to the mouse
            Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);
            //Create a plane at the player's position
            Plane playerPlane = new Plane(Vector3.up, transform.position);
            //Find where the ray intersects the plane
            float rayDistance = 0.0f;
            playerPlane.Raycast(mouseRay, out rayDistance);
            //Get the point on the ray at the distance to the plane
            Vector3 targetPoint = mouseRay.GetPoint(rayDistance);

            //Find the direction
            Vector3 direction = (targetPoint - transform.position).normalized;

            //Apply the direction
            move.ApplyDirection(direction);

        }
    }
}
