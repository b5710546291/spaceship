using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour {

	public GameObject myBullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetAxis("Horizontal") != 0 ) {
			this.gameObject.transform.Translate (Input.GetAxis ("Horizontal") * Vector3.right * Time.deltaTime *10f);
		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			Instantiate (myBullet,this.gameObject.transform.position,Quaternion.identity);
		}
		
	}
}
