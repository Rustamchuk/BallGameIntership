using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private string _firstScene;

    public void StartGame()
    {
        SceneManager.LoadScene(_firstScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
