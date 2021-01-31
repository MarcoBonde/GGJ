using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class stunCondition : MonoBehaviour
{
    public static UnityEvent Stun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Win"))
        {
            GameObject player1 = GameObject.Find("Player");
            player1.GetComponent<PlayerController>().startStun();
            Destroy(gameObject);
        }
    }
}
