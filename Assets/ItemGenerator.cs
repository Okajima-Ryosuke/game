using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

	public GameObject Ring;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++){
			float RingPosX = Random.Range(4, 497);
			float RingPosZ = Random.Range (4, 497);
			GameObject ring = Instantiate (Ring) as GameObject;
			ring.transform.position = new Vector3 (RingPosX, 150, RingPosZ);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
