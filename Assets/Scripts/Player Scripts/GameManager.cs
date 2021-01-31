using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Transform[] obstacleSpawnPoints;

    public GameObject package;
    //public GameObject forklift;
    public GameObject oil;

    public int counterPackage;
    //public int counterForklift;
    public int counterOil;

    public Transform[] spawnPackage;
    public GameObject realBox;

    float currentTime = 0f;
    float startingTime = 600;
    public TMP_Text countdownText;

    

    void Start()
    {
        Instantiate(realBox, spawnPackage[Random.Range(0, spawnPackage.Length)].position, Quaternion.identity);
        currentTime = startingTime;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            StunPackage();
        }

        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene(5);
        }

    }

    public void StunPackage()
    {
        Instantiate(package, obstacleSpawnPoints[counterPackage].position, Quaternion.identity);

        if(counterPackage <= obstacleSpawnPoints.Length -1)
        {
            counterPackage++;
        }
        else
        {
            counterPackage = 0;
        }
    }

    /*
    public void StunForklift()
    {
        Instantiate(package, spawnPoints[counterForklift]);

        if (counterForklift <= spawnPoints.Length - 1)
        {
            counterForklift++;
        }
        else
        {
            counterForklift = 0;
        }
    }
    */

    public void StunOil()
    {
        Instantiate(package, obstacleSpawnPoints[counterOil]);

        if (counterOil <= obstacleSpawnPoints.Length - 1)
        {
            counterOil++;
        }
        else
        {
            counterOil = 0;
        }
    }
}
