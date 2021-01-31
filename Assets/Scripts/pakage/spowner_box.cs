using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spowner_box : MonoBehaviour
{
    public GameObject objectToSpown;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > Random.Range(3,10))
        {
            Instantiate(objectToSpown, transform.position, Quaternion.identity);
            timer = 0;
        }
    }
}
