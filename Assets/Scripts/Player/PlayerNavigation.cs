using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum MapDirection : byte {North, East, South, West}

public class PlayerNavigation : MonoBehaviour {
	NavMeshAgent agent;
	public GameObject target;
	
	[SerializeField]
	private float stepDistance = 1f;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey) {
			target.transform.position = this.transform.position;
			HandleAction();
		}
		agent.SetDestination(target.transform.position);
	}

	private void HandleAction()
	{
		if (Input.GetKey("w"))
		{
			target.transform.position = MoveDirection(MapDirection.North);
		}
		if(Input.GetKey("a"))
		{
			target.transform.position = MoveDirection(MapDirection.West);
		}
		if(Input.GetKey("s"))
		{
			target.transform.position = MoveDirection(MapDirection.South);
		}
		if(Input.GetKey("d"))
		{
			target.transform.position = MoveDirection(MapDirection.East);
		}
	}

	private Vector3 MoveDirection(MapDirection direction)
	{
		Vector3 returnVar = target.transform.position;
		switch (direction)
		{
			case MapDirection.North:
				returnVar.z += stepDistance;
				break;
			case MapDirection.East:
				returnVar.x += stepDistance;
				break;
			case MapDirection.West:
				returnVar.x -= stepDistance;
				break;
			case MapDirection.South:
				returnVar.z -= stepDistance;
				break;
		}

		return returnVar;
	}
}
