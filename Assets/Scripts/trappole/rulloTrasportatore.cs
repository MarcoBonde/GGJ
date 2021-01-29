using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rulloTrasportatore : MonoBehaviour
{
    [SerializeField] float speed;
    Material texture;
    // Start is called before the first frame update
    void Start()
    {
        texture = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 textureOffset = new Vector2(0, (Time.time * speed) / 7);
        texture.mainTextureOffset = textureOffset;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag != "rulli")
        {
            Rigidbody BanbinoBislacco = collision.gameObject.GetComponent<Rigidbody>();

            BanbinoBislacco.velocity = transform.forward* speed;
        }
    }
}
