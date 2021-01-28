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

    public bool DashActive;
    public float DistanceDash;
    public float DistanceMove;

    Rigidbody _RG;
    public int jumpForce;

    private void Start()
    {
        _RG = GetComponent<Rigidbody>();
    }

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
        }else if(funzione == "dash forward")
        {
            DashForword();
        }else if(funzione == "dash back")
        {
            DashBack();
        }else if(funzione == "dash left")
        {
            DashLeft();
        }else if(funzione == "dash right")
        {
            DashRight();
        }
        funzione = "";
    }

    //BASIC MOVE
    public void MoveForword()
    {
        nuovaPosizione = transform.position + Vector3.forward * DistanceMove;
        VelocitaMovimento = 5;
    }

    public void MoveBack()
    {
        nuovaPosizione = transform.position - Vector3.forward * DistanceMove;
        VelocitaMovimento = 5;
    }

    public void MoveLeft()
    {
        nuovaPosizione = transform.position + Vector3.left * DistanceMove;
        VelocitaMovimento = 5;
    }

    public void MoveRight()
    {
        nuovaPosizione = transform.position + Vector3.right * DistanceMove;
        VelocitaMovimento = 5;
    }


    //DASH----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public void DashForword()
    {
        nuovaPosizione = transform.position + Vector3.forward * DistanceDash;
        VelocitaMovimento = 10;
    }

    public void DashBack()
    {
        nuovaPosizione = transform.position - Vector3.forward * DistanceDash;
        VelocitaMovimento = 10;
    }

    public void DashLeft()
    {
        nuovaPosizione = transform.position + Vector3.left * DistanceDash;
        VelocitaMovimento = 10;
    }

    public void DashRight()
    {
        nuovaPosizione = transform.position + Vector3.right * DistanceDash;
        VelocitaMovimento = 10;
    }

    public void Jump()
    {
        _RG.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

}
