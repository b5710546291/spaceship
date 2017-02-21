using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyController : MonoBehaviour {


	public GameObject myEnemy;
	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnEnemy (1f));
	}
	
	// Update is called once per frame
	void Update () {
		//Instantiate (myEnemy, this.gameObject.transform.position, Quaternion.identity);
	}

	IEnumerator SpawnEnemy(float waitTime) {
		float a = Random.Range (-7f, 6.5f);
		this.gameObject.transform.Translate (Vector3.right*(a - this.gameObject.transform.position.x));
		Instantiate (myEnemy, this.gameObject.transform.position, Quaternion.identity);

		yield return new WaitForSeconds(waitTime);
		StartCoroutine (SpawnEnemy (1f));
	}
}
