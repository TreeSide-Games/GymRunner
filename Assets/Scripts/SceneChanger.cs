using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    #region Singleton

    public static SceneChanger instance;
    private void Awake()
    {
        if(instance == null)
            instance = this;
    }

    #endregion

    public void DisplayMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void DisplayGame()
    {
        SceneManager.LoadScene("Game");
    }
}
