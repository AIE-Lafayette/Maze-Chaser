using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * A MonoBehavior that causes the GameObject to end the
 * game when it touches the target.
 **/
public class DefeatBehavior : MonoBehaviour
{
    /**
     * A reference to the Button that will restart the game.
     **/
    public Button restartButton;

    /**
     * A reference to the GameObject that will end the game when touched.
     **/
    public GameObject target;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == target)
        {
            target.SetActive(false);
            restartButton.gameObject.SetActive(true);
        }
    }
}
