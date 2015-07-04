using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	private Vector3 moveStep = new Vector3(0f, 0f, 0.2f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += moveStep;
	}
}
