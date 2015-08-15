using UnityEngine;
using System.Collections;

public class BabyControl : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
			transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z+10);
	}
}
