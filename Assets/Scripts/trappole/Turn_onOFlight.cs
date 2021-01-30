using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_onOFlight : MonoBehaviour
{
    public Light[] LUCI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TurnON()
    {
        foreach(Light L in LUCI)
        {
            L.intensity = 13f;
        }
    }
    
    public void TurnOFF()
    {
        foreach(Light L in LUCI)
        {
            L.intensity = 1f;
        }
    }
}
