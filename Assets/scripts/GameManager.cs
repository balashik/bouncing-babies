using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public GameObject baby,truk;
	public float babyInitPointX,babyInitPointY;
	public Text scoreText;
	bool WaitingTimeEnded;

	// Use this for initialization
	void Start () {
		WaitingTimeEnded = true;

	}
	
	// Update is called once per frame
	void Update () {

		scoreText.text = (truk.GetComponent<TrukControl> ().getBabyCount ()*10).ToString();
		//StartCoroutine (waitTime ());
		if (WaitingTimeEnded == true) {
			createBaby();
			WaitingTimeEnded = false;
			StartCoroutine(waitTime());
		}
	}




	IEnumerator waitTime() {
		yield return new WaitForSeconds(5);
		WaitingTimeEnded = true;

	}

	void createBaby(){
		Instantiate (baby, new Vector2 (babyInitPointX, babyInitPointY), baby.transform.rotation);


	}
}
