using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void Start()
    {
        Instantiate(realBox, spawnPackage[Random.Range(0, spawnPackage.Length)].position, Quaternion.identity);
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            StunPackage();
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
