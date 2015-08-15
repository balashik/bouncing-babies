using UnityEngine;
using System.Collections;

public class FiremenControl : MonoBehaviour {

	public float leftlimit,rightLimit;
	public float stepSize;
	void Update(){

			if (Input.GetKey (KeyCode.LeftArrow)) {
				if(transform.position.x >= leftlimit){
					transform.position = new Vector2 (transform.position.x - stepSize, transform.position.y);
				}
			}

			if (Input.GetKey (KeyCode.RightArrow)) {
				if(transform.position.x <= rightLimit){
				transform.position = new Vector2 (transform.position.x + stepSize, transform.position.y);
				}
			}
	}
}
