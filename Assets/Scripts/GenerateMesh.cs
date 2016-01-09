using RAIN.Navigation.NavMesh;
using System.Threading;
using UnityEngine;
using System.Collections;

public class GenerateMesh : MonoBehaviour {

	[SerializeField]
	private int threadCount = 4;

	private float delay = 1f;
	private float countTime = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (countTime > delay) {
			GenerateNavMesh ();
			countTime = 0;
		}
		countTime += Time.deltaTime;
	}
	
	public void GenerateNavMesh() {
		NavMeshRig rig = GetComponent<NavMeshRig>();
		rig.NavMesh.UnregisterNavigationGraph();
		rig.NavMesh.StartCreatingContours(threadCount);
		while (rig.NavMesh.Creating) {
			rig.NavMesh.CreateContours();
		}
		rig.NavMesh.RegisterNavigationGraph ();
	}
}
