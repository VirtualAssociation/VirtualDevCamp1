using UnityEngine;
using System.Collections;

public class RiftPlayer_Walk : MonoBehaviour {

	public float speed;

	void FixedUpdate() {
		float dx = Input.GetAxis ("Horizontal");
		float dz = Input.GetAxis ("Vertical");
		Vector3 currentPos = GetComponent<Rigidbody> ().position;
		GetComponent<Rigidbody> ().position = new Vector3 (
			currentPos.x + dz * speed,
			currentPos.y,
			currentPos.z + -dx * speed);
	}
}
