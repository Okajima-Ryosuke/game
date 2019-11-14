using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Point : MonoBehaviour {

	private GameObject MessageText;
	private GameObject PushKeyText;
	private GameObject RingPointText;
	private int RingPoint = 0;

	// Use this for initialization
	void Start () {
		this.MessageText = GameObject.Find ("MessageText");
		this.PushKeyText = GameObject.Find ("PushKeyText");
		this.RingPointText = GameObject.Find ("RingPointText");
	}
	
	// Update is called once per frame
	void Update () {
		if (RingPoint == 10) {
			this.MessageText.GetComponent<Text> ().text = "Clear!!";
			this.PushKeyText.GetComponent<Text> ().text =
				"PushKey [R] : Restart\nPushKey [E] : Return to Menu";
			if (Input.GetKey(KeyCode.R)) {
				SceneManager.LoadScene ("GameScene");
			}
		}
	}

	void OnCollisionEnter (Collision Other){
		if (Other.gameObject.tag == "RingTag") {
			RingPoint += 1;
			string RingP = RingPoint.ToString ();
			this.RingPointText.GetComponent<Text> ().text = "Ring : " + RingP;
			Destroy (Other.gameObject);
		}
	}
}
