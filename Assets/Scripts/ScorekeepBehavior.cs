using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * A MonoBehavior that keeps track of the current score.
 **/
public class ScorekeepBehavior : MonoBehaviour
{
    /**
     * The current score.
     **/
    public float score = 0.0f;

    public Text scoreboard;

    // Update is called once per frame
    void Update()
    {
        if (scoreboard)
            scoreboard.text = score.ToString();
    }
}
