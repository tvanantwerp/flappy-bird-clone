using UnityEngine;
using System.Collections;

public class BirdMovement : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	float flapSpeed = 17000f;
	public float forwardSpeed = 100f;

	bool didFlap = false;

	bool dead = false;

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = transform.GetComponentInChildren<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
			didFlap = true;
		}
	}

	// FixedUpdate is for physics updates
	void FixedUpdate () {
		if (dead)
			return;

		rigidbody2D.AddForce (Vector2.right * forwardSpeed);

		if (didFlap) {
			rigidbody2D.AddForce(Vector2.up * flapSpeed);

			animator.SetTrigger("DoFlap");

			didFlap = false;
		}

		if (rigidbody2D.velocity.y > 0) {
				transform.rotation = Quaternion.Euler (0, 0, 0);
		} else {
			float angle = Mathf.Lerp (0, -90, -rigidbody2D.velocity.y / 200f);
			transform.rotation = Quaternion.Euler(0, 0, angle);
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		animator.SetTrigger ("Death");
		dead = true;
	}
}
