using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptController : MonoBehaviour
{
    string funzione;

    public Text testoDaRipulire;

    public void AddFunction(string Stringa)
    {
        funzione = Stringa;
        print(funzione);
        testoDaRipulire.text = "";

        doFunction();
    }

    void doFunction()
    {
        if(funzione == "move forword")
        {
            MoveForword();
        }

        funzione = "";
    }
    void MoveForword()
    {
        transform.position = transform.position + Vector3.forward; 
    }
}
