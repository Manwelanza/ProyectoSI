using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

    public float speed = 5f;

    private CharacterController control;

	// Use this for initialization
	void Start () {
        control = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
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
	}
}
