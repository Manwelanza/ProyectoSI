using UnityEngine;
using System.Collections;

public class Movebala : MonoBehaviour {

    public float speed = 5f;

	// Use this for initialization
	void Start () {
  
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(transform.forward * Time.deltaTime * speed);
	}

    void OnCollisionEnter(Collision collider)
    {
        if (collider.collider.tag == "Cobertura")
        {
            Destroy(this.gameObject);
        }
    }
}
