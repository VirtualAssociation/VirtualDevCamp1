using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Trap_Arrows_Behaviour : MonoBehaviour {

	private bool hasShot;
	private List<GameObject> arrows;
	public GameObject arrow;
	public GameObject shooter;

	// Use this for initialization
	void Start () {
		hasShot = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		if(hasShot == false) {
			for(var i = 0; i < 1; i++) {
				Vector3 offset = new Vector3(Random.Range(-5, 5), Random.Range(-2.5f, 2.5f), 0);
				arrows.Add((GameObject)Instantiate(arrow, shooter.transform.position + offset, Quaternion.identity));
			}
			hasShot = true;
		}
		Debug.Log("ENTER");
	}

	void OnTriggerExit(Collider other) {
		// if some condition
		Debug.Log("Exiting on the Plane");
	}

}
