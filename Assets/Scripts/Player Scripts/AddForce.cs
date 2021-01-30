using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public float thrust = 1.0f;
    public Rigidbody rb;
    public Vector3 impulse = new Vector3(5.0f, 0.0f, 0.0f);
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Rigidbody>().AddForce(impulse, ForceMode.Impulse);
        }
    }
    void pacchi()
    {

    }
}
