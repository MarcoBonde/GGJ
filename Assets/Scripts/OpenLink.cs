using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenLink : MonoBehaviour
{

    public void OpenTwitchLink() {
        Application.OpenURL("https://twitchapps.com/tmi/");

    }
    public void GoBack() {
        SceneManager.LoadScene("Menu Iniziale");
    }
    public void SaveSetting() {
        HandleTextFile.writeSetting();
        GoBack();
    }
}
