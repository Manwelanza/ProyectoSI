using UnityEngine;
using RAIN.Core;
using System.Collections;
using System;

public class MovePlayer : MonoBehaviour {

    public float speed = 6f;

    private Vector3 posicionInicial;
    private CharacterController control;

	// Use this for initialization
	void Start () {
        control = GetComponent<CharacterController> ();
        posicionInicial = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P) && Time.timeScale == 0)
        {
            GetComponent<contador>().pauseUnPressed();

        }

        else if (Input.GetKeyDown(KeyCode.P) && Time.timeScale != 0)
        {
            GetComponent<contador>().pausePressed();
        }

        GameObject.Find("EnemigoSupp").GetComponentInChildren<AIRig>().AI.Motor.UpdateMotionTransforms();
        float x = 0.0f;
        float z = 0.0f;

        if (Input.GetKey(KeyCode.D) || Input.GetAxis("Horizontal") > 0.5)
            x = 1.0f;
		if (Input.GetKey(KeyCode.A) || Input.GetAxis("Horizontal") < -0.5)
            x = -1.0f;
        if (Input.GetKey(KeyCode.W) || Input.GetAxis("Vertical") > 0.5)
            z = 1.0f;
		if (Input.GetKey(KeyCode.S) || Input.GetAxis("Vertical") < -0.5)
            z = -1.0f;
        float movX = x * speed;
        float movZ = z * speed;
        Vector3 movimiento = new Vector3(movX, 0, movZ);
        control.SimpleMove(movimiento * Time.deltaTime);
        GameObject.Find("EnemigoSupp").GetComponentInChildren<AIRig>().AI.Motor.UpdateMotionTransforms();
    }

    public void muere ()
    {
        transform.position = posicionInicial;
        GetComponent<contador>().muereJugador();
    }

    void OnCollisionEnter(Collision collider)
    {
        if (collider.collider.tag == "BalaEnemigo" || collider.collider.tag == "Enemigo")
        {
            muere();		
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BalaSniper")
        {
            muere();
        }
    }
}
