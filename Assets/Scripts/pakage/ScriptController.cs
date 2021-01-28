using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptController : MonoBehaviour
{
    string funzione;

    public Text testoDaRipulire;

    Vector3 nuovaPosizione;

    [Range(0, 10)]
    public int VelocitaMovimento;


    public void AddFunction(string Stringa)
    {
        funzione = Stringa;
        print(funzione);
        testoDaRipulire.text = "";

        doFunction();
        
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, nuovaPosizione, VelocitaMovimento * Time.deltaTime);
    }

    void doFunction()
    {
        if(funzione == "move forword")
        {
            MoveForword();
        }else if(funzione == "move back")
        {
            MoveBack();
        }else if(funzione == "move left")
        {
            MoveLeft();
        }else if(funzione == "move right")
        {
            MoveRight();
        }
        funzione = "";
    }
    void MoveForword()
    {
        nuovaPosizione = transform.position + Vector3.forward;
    }

    void MoveBack()
    {
        nuovaPosizione = transform.position - Vector3.forward;
    }

    void MoveLeft()
    {
        nuovaPosizione = transform.position - Vector3.right;
    }
    
    void MoveRight()
    {
        nuovaPosizione = transform.position - Vector3.left;
    }
}
