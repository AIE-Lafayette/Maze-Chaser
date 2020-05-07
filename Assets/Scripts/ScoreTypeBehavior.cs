using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTypeBehavior : MonoBehaviour
{
    /**
     * Whether to increment or decrement the score.
     **/
    public enum ScoreType
    {
        Bonus,
        Malus
    }

    public ScoreType scoreType;
}
