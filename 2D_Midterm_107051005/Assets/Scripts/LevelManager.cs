﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void NextLeve1(string nameLv)
    {
        SceneManager.LoadScene("nameLv");
    }
    public void BackToMune  ()
    {
        SceneManager.LoadScene("初始選單");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
