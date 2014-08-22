using UnityEngine;
using System.Collections;

public class SkyMover : MonoBehaviour {

	public GameObject player;
	public float groundSpeed = 10f;

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 pos = player.transform.position;
		pos.x += groundSpeed * Time.deltaTime;
		Vector3 skyPos = new Vector3 (pos.x/1.5f, 0, 0);
		transform.position = skyPos;
	}
}
