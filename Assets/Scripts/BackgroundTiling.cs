using UnityEngine;
using System.Collections;

public class BackgroundTiling : MonoBehaviour {

	public float defaultTiles = 5f;
	public float defaultSkyWidth = 144f;
	public float defaultGroundWidth = 154f;

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.name == "sky") {
			Vector2 pos = collider.transform.position;
			pos.x += defaultSkyWidth * defaultTiles;
			collider.transform.position = pos;
		} else if (collider.name == "ground") {
			Vector2 pos = collider.transform.position;
			pos.x += defaultGroundWidth * defaultTiles;
			collider.transform.position = pos;
		}
	}

}
