using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jug_mov : MonoBehaviour {
	public float maxSpeed = 5f;
	public float speed = 15f;
	private Rigidbody2D body;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		body.AddForce (Vector2.right * speed * h);
		body.AddForce (Vector3.up * speed * v);

		if (body.velocity.x > maxSpeed) {
			body.velocity = new Vector2 (maxSpeed, body.velocity.y);
			}
		if (body.velocity.x < -maxSpeed) {
			body.velocity = new Vector2 (-maxSpeed, body.velocity.y);
		}
		if (body.velocity.y > maxSpeed) {
			body.velocity = new Vector3 (maxSpeed, body.velocity.x);
		}
		if (body.velocity.y < -maxSpeed) {
			body.velocity = new Vector3 (-maxSpeed, body.velocity.x);
		}

	}
