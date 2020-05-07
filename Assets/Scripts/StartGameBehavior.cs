using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * A MonoBehavior with a function for loading a specified scene.
 **/
public class StartGameBehavior : MonoBehaviour
{
    /**
     * Loads the specified scene.
     **/
    public void LoadScene(int sceneBuildIndex)
    {
        SceneManager.LoadScene(sceneBuildIndex);
    }
}
