﻿using UnityEngine;
using RAIN.Core;
using System.Collections;

public class MovePlayer : MonoBehaviour {

    public float speed = 5f;

    private Vector3 posicionInicial;
    private CharacterController control;

	// Use this for initialization
	void Start () {
        control = GetComponent<CharacterController> ();
        posicionInicial = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        GameObject.Find("Enemigo").GetComponentInChildren<AIRig>().AI.Motor.UpdateMotionTransforms();
        float x = 0.0f;
        float z = 0.0f;
        if (Input.GetKey(KeyCode.D))
            x = 1.0f;
        if (Input.GetKey(KeyCode.A))
            x = -1.0f;
        if (Input.GetKey(KeyCode.W))
            z = 1.0f;
        if (Input.GetKey(KeyCode.S))
            z = -1.0f;
        float movX = x * speed;
        float movZ = z * speed;
        Vector3 movimiento = new Vector3(movX, 0, movZ);
        control.SimpleMove(movimiento * Time.deltaTime);
        GameObject.Find("Enemigo").GetComponentInChildren<AIRig>().AI.Motor.UpdateMotionTransforms();
    }

    private void muere ()
    {
        transform.position = posicionInicial;
    }

    void OnCollisionEnter(Collision collider)
    {
        if (collider.collider.tag == "Bala" || collider.collider.tag == "Enemigo")
        {
            muere();
        }
    }
}
