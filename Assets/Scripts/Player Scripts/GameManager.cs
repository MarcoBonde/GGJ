using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Transform[] obstacleSpawnPointsOil;

    //public GameObject forklift;
    public GameObject oil;

    public int counterPackage;
    //public int counterForklift;
    public int counterOil;

    public Transform[] spawnPackage;
    public GameObject realBox;

    public float currentTime = 0f;
    public float startingTime = 600;
    public TMP_Text countdownText;

    public GameObject PackWinRef;
    public GameObject PackFakeRef;

    void Start()
    {
        Instantiate(PackWinRef);
        PackWinRef.transform.position = spawnPackage[Random.Range(0, spawnPackage.Length)].position;
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
        Instantiate(PackFakeRef, spawnPackage[counterPackage].position, Quaternion.identity);

        if(counterPackage <= spawnPackage.Length -1)
        {
            counterPackage++;
        }
        else
        {
            counterPackage = 0;
        }
    }
    public void CambiaPosPacco()
    {
        PackWinRef.transform.position = spawnPackage[Random.Range(0, spawnPackage.Length)].position;
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
        Instantiate(oil, obstacleSpawnPointsOil[counterOil].transform.position, Quaternion.identity);

        if (counterOil <= obstacleSpawnPointsOil.Length - 1)
        {
            counterOil++;
        }
        else
        {
            counterOil = 0;
        }
    }

}
