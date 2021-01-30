using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class olio_trigger : MonoBehaviour
{
    Rigidbody PlayerRigidoby;
    CharacterController PCC;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerRigidoby = other.GetComponent<Rigidbody>();
            PCC = other.GetComponent<CharacterController>();
            PCC.SimpleMove(other.transform.forward * 10);
        }
    }
}
