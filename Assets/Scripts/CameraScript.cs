using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
	public GameObject target;

	[SerializeField]
	private float smoothTime = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 tp = target.transform.position;
		Vector3 current = this.transform.position;
		tp.y = current.y;
		Vector3 velocity = Vector3.zero;
		
		//this.transform.position = new Vector3(tp.x, this.transform.position.y, tp.z);
		this.transform.position = Vector3.SmoothDamp (current, tp, ref velocity, smoothTime);
	}
}
