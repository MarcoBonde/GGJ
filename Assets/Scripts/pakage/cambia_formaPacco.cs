using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambia_formaPacco : MonoBehaviour
{
    public GameObject[] pacchi;
    int UltimoPacco;
    GameObject packRef;
    // Start is called before the first frame update
    void Start()
    {
        packRef = GetComponentInChildren<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiaPacco()
    {
        Destroy(packRef);
        packRef = Instantiate(pacchi[Random.Range(0, pacchi.Length)], transform.position, Quaternion.identity);
    }
}
