using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneToLvl1 : MonoBehaviour
{
    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void GoToLevelOne() 
    {
        SceneManager.LoadScene(3);
    }

public void QuitGame ()
	{
		Debug.Log("QUIT");
		Application.Quit();
	}
}
