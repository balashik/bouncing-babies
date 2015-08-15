using UnityEngine;
using System.Collections;

public class TrukControl : MonoBehaviour {

	int babyCount;
	// Use this for initialization
	void Start () {
		babyCount = 0;

	}

	void OnCollisionEnter2D(Collision2D collision){

		if (collision.gameObject.tag == "baby") {
			babyCount++;
			Destroy(collision.gameObject);
		}
	}

	public int getBabyCount(){
		return babyCount;

	}



}
