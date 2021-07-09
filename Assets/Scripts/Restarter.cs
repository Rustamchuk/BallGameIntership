using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restarter : MonoBehaviour
{
    [SerializeField] private string _menuScene;

    public void Restart()
    {
        SceneManager.LoadScene(_menuScene);
    }
}
