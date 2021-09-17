using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
	// To specify clickable layers
	[SerializeField]
    private LayerMask mask;
	
	private NavMeshAgent agent;
	
	void Start () 
	{
		agent = GetComponent<NavMeshAgent>();
	}
	
	void Update() {
		if(Input.GetMouseButtonDown(0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			
			RaycastHit hit;
			
			if(Physics.Raycast(ray, out hit, 100, mask)) {
				agent.SetDestination(hit.point);
			}
		}
	}
	
}
