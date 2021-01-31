using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColorePaccoWin : MonoBehaviour
{
    Material _mat;
    // Start is called before the first frame update
    void Start()
    {
        _mat = GetComponent<MeshRenderer>().material;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            ChangeColorPack();
        }
    }
    public void ChangeColorPack()
    {
        _mat.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0.4f, 1f));
    }
}
