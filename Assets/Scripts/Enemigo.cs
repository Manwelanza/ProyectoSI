using UnityEngine;
using RAIN.Core;
using System.Collections;

public class Enemigo : MonoBehaviour {
	
    public GameObject bala;
    public GameObject naceBala;
    public float delayDisparos = 0.5f;

    private Vector3 posicionInicial;
    private AIRig aiRig = null;
    private float contador = 0f;

    // Use this for initialization
    void Start () {
        posicionInicial = transform.position;
        aiRig = GetComponentInChildren<AIRig>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        contador += Time.deltaTime;
	}

    public void muere ()
    {
        aiRig.AI.Motor.UpdateMotionTransforms();
        transform.position = posicionInicial;
        aiRig.AI.Motor.Move();
        aiRig.AI.Motor.UpdateMotionTransforms();
    }

    public void dispara ()
    {
        if (contador > delayDisparos)
        {
			Object clone = Instantiate(bala, naceBala.transform.position, naceBala.transform.rotation);
			
            contador = 0f;
        }
    }

    void OnCollisionEnter(Collision collider)
    {
        if (collider.collider.tag == "Bala")
        {
            muere();

			GameObject player = GameObject.Find("Player");
			/*
			 * Codigo para reiniciar llegado a un limite de vidas, da problemas
			if(player.GetComponent<contador>().getMuertesEnemigo() == vidasEnemigo)
				player.GetComponent<contador>().restartGame();
			*/
			player.GetComponent<contador>().muereEnemigo();
        }
    }
}
