using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

/**
 * A MonoBehavior that causes the GameObject to move to the opposite
 * quadrant of the scene when it collides with any object. Will increment
 * the score if the other object has a ScoreType of Bonus and decrement
 * the score if the other object has a ScoreType of Malus.
 **/
public class ItemGetBehavior : MonoBehaviour
{
    /**
     * A refernce to the ScorekeepBehavior to increment or decrement.
     **/
    public ScorekeepBehavior scorekeeper;

    private void OnTriggerEnter(Collider other)
    {
        //Move to the opposite corner
        transform.position = new Vector3(-transform.position.x, transform.position.y, -transform.position.z);

        //Stop here if there is no scorekeeper
        if (!scorekeeper)
            return;

        //Get the ScoreTypeBehavior if there is one to determine whether to add or remove a point
        ScoreTypeBehavior scoreTypeBehavior = other.gameObject.GetComponent<ScoreTypeBehavior>();

        if (scoreTypeBehavior)
        {
            if (scoreTypeBehavior.scoreType == ScoreTypeBehavior.ScoreType.Bonus)
                scorekeeper.score++;
            else if (scoreTypeBehavior.scoreType == ScoreTypeBehavior.ScoreType.Malus)
                scorekeeper.score--;
        }
    }
}
