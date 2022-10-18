using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnCollision : MonoBehaviour
{
    public int sceneIndex;
    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
