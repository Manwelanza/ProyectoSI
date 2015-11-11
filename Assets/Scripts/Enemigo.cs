using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {

    private Vector3 posicionInicial;

	// Use this for initialization
	void Start () {
        posicionInicial = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
	}

    private void muere ()
    {
        transform.position = posicionInicial;
    }

    void OnCollisionEnter(Collision collider)
    {
        if (collider.collider.tag == "Bala")
        {
            muere();
        }
    }
}
