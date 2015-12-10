using UnityEngine;
using System.Collections;

public class Dispara : MonoBehaviour {

    public GameObject bala;
    public float delayDisparos = 0.5f;
    public float delayStart = 0f;
    public GameObject disparador1;
    public GameObject disparador2;
    public GameObject disparador3;
    public GameObject disparador4;

    private float contadorDisparos = 0f;
    private float contadorStart = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (contadorStart > delayStart)
        {
            if (contadorDisparos > delayDisparos)
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    Instantiate(bala, disparador1.transform.position, disparador1.transform.rotation);
                    contadorDisparos = 0f;
                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    //Instantiate(bala, disparador2.transform.position, Quaternion.Euler(new Vector3(-90, -90, 0)));
					Instantiate(bala, disparador2.transform.position, disparador2.transform.rotation);
                    contadorDisparos = 0f;
                }
                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    //Instantiate(bala, disparador3.transform.position, Quaternion.Euler(new Vector3 (0, 90, 0)));
					Instantiate(bala, disparador3.transform.position, disparador3.transform.rotation);
                    contadorDisparos = 0f;
                }
                else if (Input.GetKey(KeyCode.LeftArrow))
                {
                    //Instantiate(bala, disparador4.transform.position, Quaternion.Euler(new Vector3(-90, 0, 90)));
					Instantiate(bala, disparador4.transform.position, disparador4.transform.rotation);
                    contadorDisparos = 0f;
                }
            }
            contadorDisparos += Time.deltaTime;
        }
        else
            contadorStart += Time.deltaTime;
    }
}
