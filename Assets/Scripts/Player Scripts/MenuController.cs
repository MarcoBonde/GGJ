using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{


    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Retry()
    {
        print("Ciao");
        SceneManager.LoadScene(3);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(5);
    }

    public void Win()
    {
        SceneManager.LoadScene(4);
    }

    public void Credits()
    {
        SceneManager.LoadScene(1);
    }

    public void SecondCredits()
    {
        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
