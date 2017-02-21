using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	float speed;
	int hp;
	// Use this for initialization
	void Start () {
		speed = Random.Range (5f, 15f);
		if (speed <= 7) {
			hp = 6;
		} else if (speed <= 11) {
			hp = 2;
		} else {
			hp = 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.down * Time.deltaTime * speed);
	}

	void OnTriggerEnter (Collider other) {
		hp = hp - 1;
		Destroy (other.gameObject);
		if (hp <= 0) {
			Destroy (this.gameObject);
		}
	}
}
