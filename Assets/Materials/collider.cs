using UnityEngine;
using System.Collections;

public class collider : MonoBehaviour {
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	public float moveSpeed = 3.0F;
	private Vector3 moveDirection = Vector3.zero;

	// Use this for initialization
	void Start () {

	}

	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetKey(KeyCode.Space))
				moveDirection.y = jumpSpeed;
			if (Input.GetKeyDown(KeyCode.UpArrow))
				moveDirection.z = moveSpeed;
			if (Input.GetKeyDown(KeyCode.DownArrow))
				moveDirection.z = -1 * moveSpeed;
			if (Input.GetKeyDown(KeyCode.LeftArrow))
				moveDirection.x = moveSpeed;
			if (Input.GetKeyDown(KeyCode.RightArrow))
				moveDirection.x = -1 * moveSpeed;

		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
	void OnTriggerEnter(Collider other) {
		print (other.gameObject.name);
	}
}