using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float walkSpeed = 10f;
	public float jumpSpeed = 5f;

	private Vector2 moveSpeed;
	private Rigidbody2D rb;

	void Start() {
		moveSpeed = Vector2.zero;
	  rb = GetComponent<Rigidbody2D>();
	}

	void Update() {
		float horizontalMovement = Input.GetAxisRaw("Horizontal");
		rb.velocity = new Vector2(horizontalMovement * walkSpeed, rb.velocity.y);

		bool isJumping = Input.GetAxisRaw("Jump") == 1f;
		rb.velocity = new Vector2(rb.velocity.x, isJumping ? jumpSpeed : rb.velocity.y);
	}
}
