using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_onOFlight : MonoBehaviour
{
    public GameObject LUCI;
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
        LUCI.SetActive(true);
    }
    
    public void TurnOFF()
    {
        LUCI.SetActive(false);
    }
}
