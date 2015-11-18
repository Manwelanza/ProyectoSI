using RAIN.Core;
using UnityEngine;

public class MovimientoAutomatico : MonoBehaviour {

	[SerializeField]
	private Vector3 destino;
	private AIRig aiRig = null;
	private bool choque = false;

	void Start() {
		aiRig = GetComponentInChildren<AIRig> ();
	}

	void LateUpdate() {
		destino = GameObject.Find ("Player").transform.position;
		aiRig.AI.Motor.UpdateMotionTransforms ();
		if (choque) {
			aiRig.AI.Motor.MoveTarget.VectorTarget = transform.position + new Vector3 (0,0,1);
		}
		else {
			aiRig.AI.Motor.MoveTarget.VectorTarget = destino;
		}
		aiRig.AI.Motor.FaceTarget.VectorTarget = destino;
		aiRig.AI.Motor.Move ();
		aiRig.AI.Motor.Face ();



		aiRig.AI.Motor.ApplyMotionTransforms ();
	}

	void OnCollisionEnter(Collision collider)
	{
		if (collider.collider.tag == "Cobertura")
		{
			Debug.Log("hey!");
			//choque = true;
		}
	}

    void OnCollisionExit(Collision collider)
    {
        if (collider.collider.tag == "Cobertura")
        {
            Debug.Log("hey!2");
            choque = false;
        }
    }

}
