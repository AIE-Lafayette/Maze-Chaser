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

    /**
     * A reference to the Camera that is following the target, if needed.
     **/
    public Camera targetCamera;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == target)
        {
            Destroy(target);
            restartButton.gameObject.SetActive(true);
        }
    }
}
