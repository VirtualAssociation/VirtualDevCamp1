using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Trap_Arrows_Behaviour : MonoBehaviour {

	private bool hasShot;
	private float speed;
	private List<GameObject> arrows;
	public GameObject arrow;
	public GameObject shooter;

	// Use this for initialization
	void Start () {
		hasShot = false;
		speed = 2.5f;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		if(hasShot == false) {
			Debug.Log(other.gameObject.name);
			Vector3 offset = new Vector3(Random.Range(-shooter.GetComponent<Renderer>().bounds.size.x / 2, shooter.GetComponent<Renderer>().bounds.size.x / 2), Random.Range(-speed, speed), 0);
			arrows.Add((GameObject)Instantiate(arrow, shooter.transform.position + offset, Quaternion.identity));
			hasShot = true;
		}	
	}

	void OnTriggerExit(Collider other) {
		// if some condition
		Debug.Log("Exiting on the Plane");
	}
}