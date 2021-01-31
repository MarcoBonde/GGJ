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
        SceneManager.LoadScene(3);
    }

    public void Credits()
    {
        SceneManager.LoadScene(1);
    }

    public void SecondCredits()
    {
        SceneManager.LoadScene(2);
    }
    public void TwitchSetting() {
        SceneManager.LoadScene("TwitchSettings");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
