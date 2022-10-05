using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeSceneOnClick : MonoBehaviour
{
    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
