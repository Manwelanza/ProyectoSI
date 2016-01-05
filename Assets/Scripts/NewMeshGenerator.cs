using UnityEngine;
using RAIN.Navigation.NavMesh;
using System.Threading;

public class NavmeshGenerator : MonoBehaviour
{
	[SerializeField]
	private bool _test = false;
	[SerializeField]
	private int _threadCount = 4;
	
	// This is just to test the runtime generation
	public void Update()
	{
		if (_test)
		{
			GenerateNavmesh();
			_test = false;
		}
	}
	
	// This will regenerate the navigation mesh when called
	public void GenerateNavmesh()
	{
		NavMeshRig tRig = GetComponent<NavMeshRig>();
		
		// Unregister any navigation mesh we may already have (probably none if you are using this)
		tRig.NavMesh.UnregisterNavigationGraph();
		
		tRig.NavMesh.StartCreatingContours(_threadCount);
		while (tRig.NavMesh.Creating)
		{
			tRig.NavMesh.CreateContours();
			
			// This could be changed to a yield (and the function to a coroutine) although as 
			// of RAIN of 2.1.4.0 (fixed since then), our navigation mesh editor has issues with it
			Thread.Sleep(10);
		}
		
		tRig.NavMesh.RegisterNavigationGraph();
	}
}