using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject package;
    //public GameObject forklift;
    public GameObject oil;

    public int counterPackage;
    //public int counterForklift;
    public int counterOil;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void StunPackage()
    {
        Instantiate(package, spawnPoints[counterPackage]);

        if(counterPackage <= spawnPoints.Length -1)
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
        Instantiate(package, spawnPoints[counterOil]);

        if (counterOil <= spawnPoints.Length - 1)
        {
            counterOil++;
        }
        else
        {
            counterOil = 0;
        }
    }
}
