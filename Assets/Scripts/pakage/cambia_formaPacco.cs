using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambia_formaPacco : MonoBehaviour
{
    public GameObject[] pacchi;
    int UltimoPacco;
    public GameObject packRef;
    int conterPack;
    // Start is called before the first frame update
    void Start()
    {
        packRef = GetComponentInChildren<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CambiaPacco();
        }
    }

    public void CambiaPacco()
    {
        if (conterPack >= pacchi.Length - 1)
            conterPack = 0;
        else
            conterPack++;

        Destroy(packRef);
        packRef = Instantiate(pacchi[conterPack], packRef.transform.position, Quaternion.identity);
        packRef.transform.parent = this.gameObject.transform;
    }
}
