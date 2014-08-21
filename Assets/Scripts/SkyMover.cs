using UnityEngine;
using System.Collections;

public class SkyMover : MonoBehaviour {

	public float groundSpeed = 10f;

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 pos = transform.position;
		pos.x += groundSpeed * Time.deltaTime;
		transform.position = pos;
	}
}
