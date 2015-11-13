using RAIN.Core;
using UnityEngine;

public class MovimientoAutomatico : MonoBehaviour {

	[SerializeField]
	private Vector3 destino;
	private AIRig aiRig = null;

	void Start() {
		aiRig = GetComponentInChildren<AIRig> ();
	}

	void Update() {
		destino = GameObject.Find ("Player").transform.position;
		aiRig.AI.Motor.UpdateMotionTransforms ();
		aiRig.AI.Motor.MoveTarget.VectorTarget = destino;
		aiRig.AI.Motor.Move ();

		aiRig.AI.Motor.ApplyMotionTransforms ();
	}

}
