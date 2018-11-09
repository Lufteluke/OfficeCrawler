using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

	public GameObject bullet;

	[SerializeField]
	private float shotForce = 50f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")){
			//Debug.LogError("Pang");

			Vector3 p = this.transform.position;

			Vector3 shotSpawnLocation = new Vector3(p.x, p.y, p.z + 1.5f);
			GameObject projectile = Instantiate(bullet, shotSpawnLocation, Quaternion.identity);
			projectile.GetComponent<Rigidbody>().AddForce(shotSpawnLocation);
		}
	}
}
