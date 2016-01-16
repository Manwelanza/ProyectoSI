using UnityEngine;
using System.Collections;

public class Movebala : MonoBehaviour
{

    public float speed = 0.05f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collider)
    {
        if (collider.collider.tag == "Cobertura")
        {
            Destroy(this.gameObject);
        }

        if (collider.collider.tag == "Player" || collider.collider.tag == "Enemigo")
        {
            Destroy(this.gameObject);
        }

        if (collider.collider.tag == "Pared")
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pared")
        {
            Destroy(this.gameObject);
        }
    }
}
